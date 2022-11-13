package Prototype;

public class PhonebookFactory {
    private Phonebook phonebook;

    public PhonebookFactory(Phonebook phonebook) {
        this.phonebook = phonebook;
    }

    public void setPhonebook(Phonebook phonebook) {
        this.phonebook = phonebook;
    }

    public Phonebook copyPhonebook() {
        return (Phonebook) this.phonebook.copy();
    }
}
