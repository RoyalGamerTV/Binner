﻿using System.ComponentModel.DataAnnotations;
using System;

namespace Binner.Common.Models.Requests
{
    public class UpdateBomPartRequest
    {
        /// <summary>
        /// Primary key
        /// </summary>
        public long ProjectPartAssignmentId { get; set; }

        /// <summary>
        /// The associated project id
        /// </summary>
        public long ProjectId { get; set; }

        /// <summary>
        /// The associated part id (optional, if using PartName)
        /// </summary>
        public long? PartId { get; set; }

        /// <summary>
        /// The associated pcb id (optional)
        /// </summary>
        public long? PcbId { get; set; }

        /// <summary>
        /// If a part number isn't matched, a custom part name can be added to identify the part by name only
        /// </summary>
        public string? PartName { get; set; }

        /// <summary>
        /// The quantity of parts needed (BOM)
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Notes about this part
        /// </summary>
        public string? Notes { get; set; }

        /// <summary>
        /// Custom reference Id that can be used as a custom designator for the part
        /// </summary>
        public string? ReferenceId { get; set; }

        public PartResponse? Part { get; set; }
    }
}