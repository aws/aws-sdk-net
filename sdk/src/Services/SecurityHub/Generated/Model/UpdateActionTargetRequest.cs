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
    /// Container for the parameters to the UpdateActionTarget operation.
    /// Updates the name and description of a custom action target in Security Hub.
    /// </summary>
    public partial class UpdateActionTargetRequest : AmazonSecurityHubRequest
    {
        private string _actionTargetArn;
        private string _description;
        private string _name;

        /// <summary>
        /// Gets and sets the property ActionTargetArn. 
        /// <para>
        /// The ARN of the custom action target to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ActionTargetArn
        {
            get { return this._actionTargetArn; }
            set { this._actionTargetArn = value; }
        }

        // Check to see if ActionTargetArn property is set
        internal bool IsSetActionTargetArn()
        {
            return this._actionTargetArn != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The updated description for the custom action target.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The updated name of the custom action target.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}