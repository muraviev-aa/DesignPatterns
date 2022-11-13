package Prototype;

import java.util.HashMap;
import java.util.Map;

public class Main {
    public static void main(String[] args) {
        Map<String, Long> namesAndNums = new HashMap<>();
        namesAndNums.put("John", 82222222222L);
        namesAndNums.put("Anna", 83333333333L);
        namesAndNums.put("Katie", 81111111111L);
        namesAndNums.put("Bob", 84444444444L);

        Phonebook phonebook = new Phonebook(namesAndNums);
        System.out.println(phonebook);

        PhonebookFactory phonebookFactory = new PhonebookFactory(phonebook);
        Phonebook copyPhonebooke = phonebookFactory.copyPhonebook();
        System.out.println(copyPhonebooke);

        try {
            Phonebook clone = (Phonebook) phonebook.clone();
            System.out.println(clone);
        } catch (CloneNotSupportedException e) {
            throw new RuntimeException(e);
        }
    }
}
