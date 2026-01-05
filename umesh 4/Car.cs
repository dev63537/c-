class Car {
    String name;

    public void speed() {
        System.out.println("speeding");
    }
}

class Alto extends Car {
    public void display() {
        System.out.println("this is Alto class display method");
    }
}

class Main {
    public static void main(String[] args) {
        Alto a = new Alto();
        a.name = "fortuner";
        a.display();
        a.speed();
    }
}
