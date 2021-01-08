using Amazon.S3.Model.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.S3.Model
{
	/// <summary>
	/// Filter Predicate abstract class for specific filter types to be derived from.
	/// </summary>
	public abstract class IntelligentTieringFilterPredicate
	{
		internal abstract void Accept(IIntelligentTieringPredicateVisitor intelligentTieringPredicateVisitor);
	}
}
