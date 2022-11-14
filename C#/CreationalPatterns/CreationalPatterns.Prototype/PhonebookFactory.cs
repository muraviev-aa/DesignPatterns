namespace CreationalPatterns.Prototype
{
    internal class PhonebookFactory
    {
        private Phonebook phonebook;

        public PhonebookFactory(Phonebook phonebook)
        {
            this.phonebook = phonebook;
        }

        public void SetPhonebook(Phonebook phonebook)
        {
            this.phonebook = phonebook;
        }

        public Phonebook CopyPhonebooke()
        {
            return (Phonebook)this.phonebook.Copy();
        }
    }
}
