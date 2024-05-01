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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Container for the parameters to the GetCollaborationPrivacyBudgetTemplate operation.
    /// Returns details about a specified privacy budget template.
    /// </summary>
    public partial class GetCollaborationPrivacyBudgetTemplateRequest : AmazonCleanRoomsRequest
    {
        private string _collaborationIdentifier;
        private string _privacyBudgetTemplateIdentifier;

        /// <summary>
        /// Gets and sets the property CollaborationIdentifier. 
        /// <para>
        /// A unique identifier for one of your collaborations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string CollaborationIdentifier
        {
            get { return this._collaborationIdentifier; }
            set { this._collaborationIdentifier = value; }
        }

        // Check to see if CollaborationIdentifier property is set
        internal bool IsSetCollaborationIdentifier()
        {
            return this._collaborationIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property PrivacyBudgetTemplateIdentifier. 
        /// <para>
        /// A unique identifier for one of your privacy budget templates.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string PrivacyBudgetTemplateIdentifier
        {
            get { return this._privacyBudgetTemplateIdentifier; }
            set { this._privacyBudgetTemplateIdentifier = value; }
        }

        // Check to see if PrivacyBudgetTemplateIdentifier property is set
        internal bool IsSetPrivacyBudgetTemplateIdentifier()
        {
            return this._privacyBudgetTemplateIdentifier != null;
        }

    }
}