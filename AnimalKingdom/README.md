```mermaid

    classDiagram
		Animal <|-- Cat
		Animal <|-- Dog
	class Animal{
		+Virtual String Sound()
	}
	class Cat{
        +Override String Sound()
    }
	class Dog{
		+Override String Sound()
	}
```