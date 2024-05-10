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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
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
namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Provides the configuration information for your Amazon Kendra experience. This includes
    /// the data source IDs and/or FAQ IDs, and user or group information to grant access
    /// to your Amazon Kendra experience.
    /// </summary>
    public partial class ExperienceConfiguration
    {
        private ContentSourceConfiguration _contentSourceConfiguration;
        private UserIdentityConfiguration _userIdentityConfiguration;

        /// <summary>
        /// Gets and sets the property ContentSourceConfiguration. 
        /// <para>
        /// The identifiers of your data sources and FAQs. Or, you can specify that you want to
        /// use documents indexed via the <c>BatchPutDocument</c> API. This is the content you
        /// want to use for your Amazon Kendra experience.
        /// </para>
        /// </summary>
        public ContentSourceConfiguration ContentSourceConfiguration
        {
            get { return this._contentSourceConfiguration; }
            set { this._contentSourceConfiguration = value; }
        }

        // Check to see if ContentSourceConfiguration property is set
        internal bool IsSetContentSourceConfiguration()
        {
            return this._contentSourceConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property UserIdentityConfiguration. 
        /// <para>
        /// The IAM Identity Center field name that contains the identifiers of your users, such
        /// as their emails.
        /// </para>
        /// </summary>
        public UserIdentityConfiguration UserIdentityConfiguration
        {
            get { return this._userIdentityConfiguration; }
            set { this._userIdentityConfiguration = value; }
        }

        // Check to see if UserIdentityConfiguration property is set
        internal bool IsSetUserIdentityConfiguration()
        {
            return this._userIdentityConfiguration != null;
        }

    }
}