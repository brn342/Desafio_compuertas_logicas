using Compuertas;

IGate and1 = new AndGate("and1");
IGate and2 = new AndGate("and2");
IGate or1 = new OrGate("or1");
IGate and3 = new AndGate("and3");


IInput valor_a = new LogicValue(false); 
IInput valor_b = new LogicValue(false);
IInput valor_c = new LogicValue(true);

IGate not_a = new NotGate("not1", valor_a);
IGate not_b = new NotGate("not1", valor_b);
Console.WriteLine(not_a.BoolValue());
Console.WriteLine(not_b.BoolValue());

and1.AddInput(valor_a);
and1.AddInput(valor_b);

and2.AddInput(not_a);
and2.AddInput(not_b);

or1.AddInput(and1);
or1.AddInput(and2);
Console.WriteLine("Resultado de OR1 Gate: " + or1.BoolValue());

and3.AddInput(valor_c);
and3.AddInput(or1);

Console.WriteLine("Resultado de AND Gate: " + and3.BoolValue());
//Console.WriteLine("Resultado de AND Gate: " + and3.BoolValue());
