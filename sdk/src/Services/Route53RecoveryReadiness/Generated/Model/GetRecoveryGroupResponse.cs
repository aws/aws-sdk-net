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
 * Do not modify this file. This file is generated from the route53-recovery-readiness-2019-12-02.normal.json service model.
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
namespace Amazon.Route53RecoveryReadiness.Model
{
    /// <summary>
    /// This is the response object from the GetRecoveryGroup operation.
    /// </summary>
    public partial class GetRecoveryGroupResponse : AmazonWebServiceResponse
    {
        private List<string> _cells = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _recoveryGroupArn;
        private string _recoveryGroupName;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Cells. 
        /// <para>
        /// A list of a cell's Amazon Resource Names (ARNs).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Cells
        {
            get { return this._cells; }
            set { this._cells = value; }
        }

        // Check to see if Cells property is set
        internal bool IsSetCells()
        {
            return this._cells != null && (this._cells.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RecoveryGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the recovery group.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string RecoveryGroupArn
        {
            get { return this._recoveryGroupArn; }
            set { this._recoveryGroupArn = value; }
        }

        // Check to see if RecoveryGroupArn property is set
        internal bool IsSetRecoveryGroupArn()
        {
            return this._recoveryGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property RecoveryGroupName. 
        /// <para>
        /// The name of the recovery group.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string RecoveryGroupName
        {
            get { return this._recoveryGroupName; }
            set { this._recoveryGroupName = value; }
        }

        // Check to see if RecoveryGroupName property is set
        internal bool IsSetRecoveryGroupName()
        {
            return this._recoveryGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the recovery group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}