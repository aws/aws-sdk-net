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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
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
namespace Amazon.MailManager.Model
{
    /// <summary>
    /// This is the response object from the GetAddonInstance operation.
    /// </summary>
    public partial class GetAddonInstanceResponse : AmazonWebServiceResponse
    {
        private string _addonInstanceArn;
        private string _addonName;
        private string _addonSubscriptionId;
        private DateTime? _createdTimestamp;

        /// <summary>
        /// Gets and sets the property AddonInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Add On instance.
        /// </para>
        /// </summary>
        public string AddonInstanceArn
        {
            get { return this._addonInstanceArn; }
            set { this._addonInstanceArn = value; }
        }

        // Check to see if AddonInstanceArn property is set
        internal bool IsSetAddonInstanceArn()
        {
            return this._addonInstanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property AddonName. 
        /// <para>
        /// The name of the Add On provider associated to the subscription of the instance.
        /// </para>
        /// </summary>
        public string AddonName
        {
            get { return this._addonName; }
            set { this._addonName = value; }
        }

        // Check to see if AddonName property is set
        internal bool IsSetAddonName()
        {
            return this._addonName != null;
        }

        /// <summary>
        /// Gets and sets the property AddonSubscriptionId. 
        /// <para>
        /// The subscription ID associated to the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=67)]
        public string AddonSubscriptionId
        {
            get { return this._addonSubscriptionId; }
            set { this._addonSubscriptionId = value; }
        }

        // Check to see if AddonSubscriptionId property is set
        internal bool IsSetAddonSubscriptionId()
        {
            return this._addonSubscriptionId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The timestamp of when the Add On instance was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp
        {
            get { return this._createdTimestamp; }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

    }
}