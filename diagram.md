```mermaid
classDiagram
    direction TB
    
    %% Interfaces
    class IProjectAssignable {
        <<interface>>
        +GetProjectsList() string[]
    }

    class ILevelable {
        <<interface>>
        +Level string
    }
    
    class IProjectIncomeCalculable {
        <<interface>>
        +CalculateProjectIncome(hours: int): double
    }

    %% Base Class
    class Employee {
        <<abstract>>
        +Position string
        +Experience int
        +AnnualSalary double
        +CalcMonthSalary() double
        +GetProjectsList() string[]
    }
    
    %% Derived Classes
    class Programmer {
        +Level string
        +CalculateBonus() double
    }
    
    class Designer {
        +Specialization string
        +ProjectHoursWorked int
        +CalculateProjectIncome(hours: int): double
    }

    %% Relationships
    
    %% Inheritance
    Employee <|-- Programmer : успадкування
    Employee <|-- Designer : успадкування
    
    %% Interface Implementation (dotted line with triangle head)
    IProjectAssignable <|.. Employee : реалізує
    ILevelable <|.. Programmer : реалізує
    IProjectIncomeCalculable <|.. Designer : реалізує
    
    %% Association (Optional SalaryManager from previous diagram)
    SalaryManager --|> Employee : агрегація/залежність (якщо потрібен зовнішній клас)

    %% Notes:
    note for Employee "CalcMonthSalary та GetProjectsList є абстрактними/віртуальними методами."