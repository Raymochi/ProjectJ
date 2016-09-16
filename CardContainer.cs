public abstract class CardContainer {
	protected Queue<Card> cards;

	public CardContainer(Queue<Card> cards) {
		this.cards = cards;
	}

	public void Shuffle() {

	}

	public Card First() {
		return cards.Peek();
	}

	public void Search(Card card) {

	}

}