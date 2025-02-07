﻿using System;
using ATF.Repository.Attributes;

namespace ATF.Repository.UnitTests.Models
{
	[Schema("Lead")]
	public class Lead: BaseModel
	{
		[SchemaProperty("Contact")]
		public string Contact { get; set; }

		[SchemaProperty("Account")]
		public string Account { get; set; }

		[SchemaProperty("NewLeadType")]
		public Guid NewLeadTypeId { get; set; }

		[SchemaProperty("AnnualRevenueBC")]
		public decimal AnnualRevenueBC { get; set; }

		[SchemaProperty("IsTrialConfirmed")]
		public bool IsTrialConfirmed { get; set; }

		[SchemaProperty("DecisionDate")]
		public DateTime DecisionDate { get; set; }

	}
}
