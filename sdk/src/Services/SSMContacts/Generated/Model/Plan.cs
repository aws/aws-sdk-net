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
 * Do not modify this file. This file is generated from the ssm-contacts-2021-05-03.normal.json service model.
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
namespace Amazon.SSMContacts.Model
{
    /// <summary>
    /// Information about the stages and on-call rotation teams associated with an escalation
    /// plan or engagement plan.
    /// </summary>
    public partial class Plan
    {
        private List<string> _rotationIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Stage> _stages = AWSConfigs.InitializeCollections ? new List<Stage>() : null;

        /// <summary>
        /// Gets and sets the property RotationIds. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the on-call rotations associated with the plan.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=25)]
        public List<string> RotationIds
        {
            get { return this._rotationIds; }
            set { this._rotationIds = value; }
        }

        // Check to see if RotationIds property is set
        internal bool IsSetRotationIds()
        {
            return this._rotationIds != null && (this._rotationIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Stages. 
        /// <para>
        /// A list of stages that the escalation plan or engagement plan uses to engage contacts
        /// and contact methods.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Stage> Stages
        {
            get { return this._stages; }
            set { this._stages = value; }
        }

        // Check to see if Stages property is set
        internal bool IsSetStages()
        {
            return this._stages != null && (this._stages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}