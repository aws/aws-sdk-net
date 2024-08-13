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

/*
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about an instance in the DB cluster.
    /// </summary>
    public partial class AwsRdsDbClusterMember
    {
        private string _dbClusterParameterGroupStatus;
        private string _dbInstanceIdentifier;
        private bool? _isClusterWriter;
        private int? _promotionTier;

        /// <summary>
        /// Gets and sets the property DbClusterParameterGroupStatus. 
        /// <para>
        /// The status of the DB cluster parameter group for this member of the DB cluster.
        /// </para>
        /// </summary>
        public string DbClusterParameterGroupStatus
        {
            get { return this._dbClusterParameterGroupStatus; }
            set { this._dbClusterParameterGroupStatus = value; }
        }

        // Check to see if DbClusterParameterGroupStatus property is set
        internal bool IsSetDbClusterParameterGroupStatus()
        {
            return this._dbClusterParameterGroupStatus != null;
        }

        /// <summary>
        /// Gets and sets the property DbInstanceIdentifier. 
        /// <para>
        /// The instance identifier for this member of the DB cluster.
        /// </para>
        /// </summary>
        public string DbInstanceIdentifier
        {
            get { return this._dbInstanceIdentifier; }
            set { this._dbInstanceIdentifier = value; }
        }

        // Check to see if DbInstanceIdentifier property is set
        internal bool IsSetDbInstanceIdentifier()
        {
            return this._dbInstanceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property IsClusterWriter. 
        /// <para>
        /// Whether the cluster member is the primary instance for the DB cluster.
        /// </para>
        /// </summary>
        public bool? IsClusterWriter
        {
            get { return this._isClusterWriter; }
            set { this._isClusterWriter = value; }
        }

        // Check to see if IsClusterWriter property is set
        internal bool IsSetIsClusterWriter()
        {
            return this._isClusterWriter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PromotionTier. 
        /// <para>
        /// Specifies the order in which an Aurora replica is promoted to the primary instance
        /// when the existing primary instance fails.
        /// </para>
        /// </summary>
        public int? PromotionTier
        {
            get { return this._promotionTier; }
            set { this._promotionTier = value; }
        }

        // Check to see if PromotionTier property is set
        internal bool IsSetPromotionTier()
        {
            return this._promotionTier.HasValue; 
        }

    }
}