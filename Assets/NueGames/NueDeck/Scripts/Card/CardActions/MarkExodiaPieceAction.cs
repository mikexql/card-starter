using NueGames.NueDeck.Scripts.Enums;
using NueGames.NueDeck.Scripts.Managers;
using UnityEngine;

namespace NueGames.NueDeck.Scripts.Card.CardActions
{
    public class MarkExodiaPieceAction : CardActionBase
    {
        public string pieceId; // e.g. "Exodia_Head"
        public override CardActionType ActionType => CardActionType.MarkExodiaPiece;

        public override void DoAction(CardActionParameters actionParameters)
        {
            var selfCharacter = actionParameters.SelfCharacter;
            Exodia.Mark(string.IsNullOrEmpty(pieceId) ? actionParameters.CardData.Id : pieceId);
            selfCharacter.CharacterStats.ApplyStatus(StatusType.TeoEnMing,1);
        }
    }
}
