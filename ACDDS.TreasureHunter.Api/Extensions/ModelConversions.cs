using ACDDS.TreasureHunter.Api.Models.Response;
using ACDDS.TreasureHunter.Core.Models;
using System;
using System.Collections.Generic;

namespace ACDDS.TreasureHunter.Api.Extensions
{
    public static class ModelConversions
    {
        public static EquipmentResponse ToEquipmentResponseModel(this Equipment src)
        {
            return new EquipmentResponse()
            {
                Id = src.Id,
                Name = src.Name,
                Type = src.Type.ToString(),
                HpModifier = src.HpModifier,
                LuckModifier = src.LuckModifier,
                Value = src.Value
            };
        }

        private static Random rng = new Random();

        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
