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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Neptune.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyGlobalCluster operation. Modify a setting
    /// for an Amazon Neptune global cluster. You can change one or more database configuration
    /// parameters by specifying these parameters and their new values in the request.
    /// </summary>
    public partial class ModifyGlobalClusterRequest : AmazonNeptuneRequest
    {
        /// <summary>
        /// Gets and sets the property AllowMajorVersionUpgrade. 
        /// <para>
        /// A value that indicates whether major version upgrades are allowed.
        /// </para>
        ///  
        /// <para>
        /// Constraints: You must allow major version upgrades if you specify a value for the
        /// <c>EngineVersion</c> parameter that is a different major version than the DB cluster's
        /// current version.
        /// </para>
        ///  
        /// <para>
        /// If you upgrade the major version of a global database, the cluster and DB instance
        /// parameter groups are set to the default parameter groups for the new version, so you
        /// will need to apply any custom parameter groups after completing the upgrade.
        /// </para>
        /// </summary>
        public bool? AllowMajorVersionUpgrade { get; set; }

        /// <summary>
        /// Checks to see if the AllowMajorVersionUpgrade property is set.
        /// </summary>
        internal bool IsSetAllowMajorVersionUpgrade() => this.AllowMajorVersionUpgrade.HasValue;

        /// <summary>
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// Indicates whether the global database has deletion protection enabled. The global
        /// database cannot be deleted when deletion protection is enabled.
        /// </para>
        /// </summary>
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// Checks to see if the DeletionProtection property is set.
        /// </summary>
        internal bool IsSetDeletionProtection() => this.DeletionProtection.HasValue;

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The version number of the database engine to which you want to upgrade. Changing this
        /// parameter will result in an outage. The change is applied during the next maintenance
        /// window unless <c>ApplyImmediately</c> is enabled.
        /// </para>
        ///  
        /// <para>
        /// To list all of the available Neptune engine versions, use the following command:
        /// </para>
        /// </summary>
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property GlobalClusterIdentifier. 
        /// <para>
        /// The DB cluster identifier for the global cluster being modified. This parameter is
        /// not case-sensitive.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must match the identifier of an existing global database cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string GlobalClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the GlobalClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetGlobalClusterIdentifier() => this.GlobalClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property NewGlobalClusterIdentifier. 
        /// <para>
        /// A new cluster identifier to assign to the global database. This value is stored as
        /// a lowercase string.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must contain from 1 to 63 letters, numbers, or hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The first character must be a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't end with a hyphen or contain two consecutive hyphens
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <c>my-cluster2</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string NewGlobalClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the NewGlobalClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetNewGlobalClusterIdentifier() => this.NewGlobalClusterIdentifier != null;
    }
}
