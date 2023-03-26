using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pw5._5
{
    interface Ispells
    {
        void MagicWand();
    }

    class Spell
    {
        public int Mana { get; private set; }
        private string Effect { get; set; }
        public string SpellName { get; set; }

        public Spell(int mana, string effect, string spellName)
        {
            Mana = mana;
            Effect = effect;
            SpellName = spellName;
        }
        public void Use(string name)
        {
            Console.WriteLine($"{name} кастует {SpellName} \n {Effect} ");
        }
    }
    //
    class Magician
    {
        public string Name { get; private set; }
        public int Mana { get; private set; }

        public Magician(string name, int mana)
        {
            Name = name;
            Mana = mana;
        }
        public void CastSpell(Spell spell)
        {
            if (Mana >= spell.Mana)
            {
                spell.Use(Name);
                Mana -= spell.Mana;
                Console.WriteLine($"Осталось {Mana} маны");
            }
            else
            {
                Console.WriteLine($"Для использования {spell.SpellName} не хватает {spell.Mana - Mana} единиц маны. Нажмите стики");
            }
        }
    }
    class Stick : Ispells
    {
        public void MagicWand()
        {
            Console.WriteLine("Вы использовали стики");
        }

        class Program
        {
            static void Main()
            {
                Spell spiritLance = new Spell(120, "Наше копьё найдёт тебя!", "spirit lance");
                Spell doppelGanger = new Spell(50, "Множимся!", "doppelganger");
                Magician phantomLancer = new Magician("Phantom Lancer", 160);

                phantomLancer.CastSpell(spiritLance);
                phantomLancer.CastSpell(doppelGanger);
                Ispells Mana = new Stick();
                Mana.MagicWand();
                Console.ReadKey(true);
            }
        }
    }
}