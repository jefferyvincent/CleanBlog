//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v8.9.1
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder.Embedded;

namespace Umbraco.Web.PublishedModels
{
	// Mixin Content Type with alias "retentionControls"
	/// <summary>Retention Controls</summary>
	public partial interface IRetentionControls : IPublishedContent
	{
		/// <summary>Leave Message</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.9.1")]
		string LeaveMessage { get; }
	}

	/// <summary>Retention Controls</summary>
	[PublishedModel("retentionControls")]
	public partial class RetentionControls : PublishedContentModel, IRetentionControls
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.9.1")]
		public new const string ModelTypeAlias = "retentionControls";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.9.1")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.9.1")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.9.1")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<RetentionControls, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public RetentionControls(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Leave Message: Enter the message for the browser title for when the user is about to leave.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.9.1")]
		[ImplementPropertyType("leaveMessage")]
		public string LeaveMessage => GetLeaveMessage(this);

		/// <summary>Static getter for Leave Message</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.9.1")]
		public static string GetLeaveMessage(IRetentionControls that) => that.Value<string>("leaveMessage");
	}
}
