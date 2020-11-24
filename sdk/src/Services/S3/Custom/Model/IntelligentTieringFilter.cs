/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.S3.Model
{
	/// <summary>
	/// <para>The <code>Filter</code> is used to identify objects that the 
	/// S3 Intelligent-Tiering configuration applies to.</para>
	/// </summary>
	public class IntelligentTieringFilter
	{
		private IntelligentTieringFilterPredicate intelligentTieringFilterPredicate;

		/// <summary>
		/// Filter Predicate setup for specific filter types.
		/// </summary>
		public IntelligentTieringFilterPredicate IntelligentTieringFilterPredicate
		{
			get { return this.intelligentTieringFilterPredicate; }
			set { this.intelligentTieringFilterPredicate = value; }
		}
	}
}
