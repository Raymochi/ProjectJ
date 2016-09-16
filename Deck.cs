public class Deck : CardContainer {
	public Deck(Queue<Card> cards) {
		this.cards = cards;
	}

	public Card Draw() {
		this.cards.Dequeue();
	}
} 