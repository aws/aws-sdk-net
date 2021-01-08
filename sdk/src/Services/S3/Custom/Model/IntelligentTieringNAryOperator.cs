﻿/*
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
	/// Abstract class that can be used over logical filter predicates,i.e. AND/OR.
	/// </summary>
	public abstract class IntelligentTieringNAryOperator : IntelligentTieringFilterPredicate
	{
		private readonly List<IntelligentTieringFilterPredicate> operands;

		protected IntelligentTieringNAryOperator(List<IntelligentTieringFilterPredicate> operands)
		{
			this.operands = operands;
		}

		public List<IntelligentTieringFilterPredicate> Operands
		{
			get { return this.operands; }
		}
	}
}
