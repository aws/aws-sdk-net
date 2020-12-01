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
using System.Linq;
using System.Text;

namespace Amazon.S3.Model
{
	/// <summary>
	/// <para>A filter that you can specify for selection for modifications on replicas. 
	/// Amazon S3 doesn't replicate replica modifications by default. In the latest version 
	/// of replication configuration (when <code>Filter</code> is specified), you can specify 
	/// this element and set the status to <code>Enabled</code> to replicate modifications on 
	/// replicas. </para> <note> <para> If you don't specify the <code>Filter</code> element, Amazon S3 
	/// assumes that the replication configuration is the earlier version, V1. In the earlier version, 
	/// this element is not allowed.</para> </note>
	/// </summary>
	public class ReplicaModifications
	{
		private ReplicaModificationsStatus status;

		/// <summary>
		/// <para>Specifies whether Amazon S3 replicates modifications on replicas.</para>
		/// </summary>
		public ReplicaModificationsStatus Status
		{
			get { return this.status; }
			set { this.status = value; }
		}

		internal bool IsSetStatus()
		{
			return this.status != null;
		}
	}
}
