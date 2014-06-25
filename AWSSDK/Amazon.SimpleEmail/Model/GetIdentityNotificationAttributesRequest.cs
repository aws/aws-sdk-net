/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Container for the parameters to the GetIdentityNotificationAttributes operation.
    /// Given a list of verified identities (email addresses and/or domains), returns a structure
    /// describing identity         notification attributes.
    /// 
    ///         
    /// <para>
    /// This action is throttled at one request per second.
    /// </para>
    ///         
    /// <para>
    /// For more information about feedback notification, see the             <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/bounce-complaint-notifications.html">Amazon
    /// SES Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class GetIdentityNotificationAttributesRequest : AmazonWebServiceRequest
    {
        private List<string> _identities = new List<string>();


        /// <summary>
        /// Gets and sets the property Identities. 
        /// <para>
        /// A list of one or more identities.
        /// </para>
        /// </summary>
        public List<string> Identities
        {
            get { return this._identities; }
            set { this._identities = value; }
        }

        /// <summary>
        /// Sets the Identities property
        /// </summary>
        /// <param name="identities">The values to add to the Identities collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetIdentityNotificationAttributesRequest WithIdentities(params string[] identities)
        {
            foreach (var element in identities)
            {
                this._identities.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the Identities property
        /// </summary>
        /// <param name="identities">The values to add to the Identities collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetIdentityNotificationAttributesRequest WithIdentities(IEnumerable<string> identities)
        {
            foreach (var element in identities)
            {
                this._identities.Add(element);
            }
            return this;
        }
        // Check to see if Identities property is set
        internal bool IsSetIdentities()
        {
            return this._identities != null && this._identities.Count > 0; 
        }

    }
}