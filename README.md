# Wahrscheinlichkeitsrechner-v2
Ein einfaches Tool in C# um verschiedene wahrscheinlichkeitsrelevante Daten zu errechnen. Enthält drei Tabs: Länge der Ketter n; n Versuche, mindestens 1 Treffer.

# Was genau kann dieses Tool?

Länge der Kette n
-
Berechnet wieviele Zufallsversuche (n) gemacht werden müssen, damit mit einer Wahrscheinlichkeit von a mindestens ein Treffer gelandet wird.

a: gewünschte Wahrscheinlichkeit für mindestens einen Treffer (0<a<1)
p: Trefferwahrscheinlichkeit bei einem Zufallsversuch (0<p<1)
a und p dürfen nicht beide 1 sein.

n Versuche
-
Berechnet die Wahrscheinlichkeit (P) für genau k Treffer bei n Zufallsversuchen
n= Anzahl der Zufallsversuche (ganze Zahl)
k= Anzahl der gewünschten Treffer (ganze Zahl)
p= Wahrscheinlichkeit für einen Treffer (0<p<1)

mindestens 1 Treffer
-
Berechnet die Wahrscheinlichkeit (P) für mindestens einen Treffer bei n Zufallsversuchen.

n: Anzahl der Zufallsversuche (ganze Zahl)
p: Trefferwahrscheinlichkeit bei einem Zufallsversuch (0<p<1)


# Features
- nutzt den Typ double für die Ein- und Ausgabe (bis zu 15 Nachkommastellen)
- bei ungültiger Eingabe wird ein Warnhinweis angezeigt, das entsprechende Feld rot hinterlegt und der Berechnen-Knopf deaktiviert
- Knopf zum Zurücksetzen der Felder
