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
	/// <para>Specifies the S3 Intelligent-Tiering configuration for an Amazon S3 bucket.</para> 
	/// <para>For information about the S3 Intelligent-Tiering storage class, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage-class-intro.html#sc-dynamic-data-access\">Storage class for automatically optimizing frequently and infrequently accessed objects</a>.</para>
	/// </summary>
	public class IntelligentTieringConfiguration
	{
		private string intelligentTieringId;
		private IntelligentTieringFilter intelligentTieringFilter;
		private IntelligentTieringStatus status;
		private List<Tiering> tierings = AWSConfigs.InitializeCollections ? new List<Tiering>() : null;

		/// <summary>
		/// <para>The ID used to identify the S3 Intelligent-Tiering configuration.</para>
		/// </summary>
		public string IntelligentTieringId
		{
			get { return this.intelligentTieringId; }
			set { this.intelligentTieringId = value; }
		}

		// Check to see if IntelligentTieringId property is set
		internal bool IsSetIntelligentTieringId()
		{
			return !(string.IsNullOrEmpty(this.intelligentTieringId));
		}

		/// <summary>
		/// <para>Specifies a bucket filter. 
		/// The configuration only includes objects that meet the filter's criteria.</para>
		/// </summary>
		public IntelligentTieringFilter IntelligentTieringFilter
		{
			get { return this.intelligentTieringFilter; }
			set { this.intelligentTieringFilter = value; }
		}

		// Check to see if InventoryFilter property is set
		internal bool IsSetIntelligentTieringFilter()
		{
			return this.intelligentTieringFilter != null;
		}

		/// <summary>
		/// <para>Specifies the status of the configuration.</para>
		/// </summary>
		public IntelligentTieringStatus Status
		{
			get { return this.status; }
			set { this.status = value; }
		}

		// Check to see if Status property is set
		internal bool IsSetStatus()
		{
			return this.status != null;
		}

		/// <summary>
		/// <para>Specifies the S3 Intelligent-Tiering storage class tier of the configuration.</para>
		/// </summary>
		public List<Tiering> Tierings
		{
			get { return this.tierings; }
			set { this.tierings = value; }
		}

		// Check if the tieringList property is set
		internal bool IsSetTieringList()
		{
            return this.tierings != null && (this.tierings.Count > 0 || !AWSConfigs.InitializeCollections);
        }
	}
}
