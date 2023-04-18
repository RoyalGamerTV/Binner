﻿using System;

namespace Binner.Common.Models
{
    public class ProjectPcbProduceHistory
    {
        /// <summary>
        /// Primary key
        /// </summary>
        public long ProjectPcbProduceHistoryId { get; set; }

        /// <summary>
        /// The parent production record
        /// </summary>
        public long ProjectProduceHistoryId { get; set; }

        /// <summary>
        /// Pcb that was produced
        /// </summary>
        public long? PcbId { get; set; }

        /// <summary>
        /// Quantity of PCBs that are produced on every production (snapshot of PCB value)
        /// </summary>
        public int PcbQuantity { get; set; }

        /// <summary>
        /// Cost to produce a single PCB board (snapshot of PCB value)
        /// </summary>
        public double PcbCost { get; set; }

        /// <summary>
        /// The serial number of the produced pcb (or null for unassociated productions)
        /// </summary>
        public string? SerialNumber { get; set; }

        /// <summary>
        /// Creation date
        /// </summary>
        public DateTime DateCreatedUtc { get; set; }

        public DateTime DateModifiedUtc { get; set; }
    }
}
