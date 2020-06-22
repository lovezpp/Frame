using Dapper.Contrib.Extensions;
using System;

namespace YXH.Entities.Entity
{

	/// <summary>
	///T_Schedule
	/// </summary>
	[Table("T_Schedule")]
	public class Schedule : EntityMetadata
	{
		/// <summary>
		/// ID
		/// </summary>		
		public string ID { get; set; }
		/// <summary>
		/// Acid
		/// </summary>		
		public string Acid { get; set; }
		/// <summary>
		/// Status
		/// </summary>		
		public int? Status { get; set; }
		/// <summary>
		/// Name
		/// </summary>		
		public string Name { get; set; }
		/// <summary>
		/// Description
		/// </summary>		
		public string Description { get; set; }
		/// <summary>
		/// Project
		/// </summary>		
		public string Project { get; set; }
		/// <summary>
		/// BeginTime
		/// </summary>		
		public DateTime? BeginTime { get; set; }
		/// <summary>
		/// EndTime
		/// </summary>		
		public DateTime? EndTime { get; set; }

	}
}