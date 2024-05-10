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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
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
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Query argument-profile mapping for field-level encryption.
    /// </summary>
    public partial class QueryArgProfile
    {
        private string _profileId;
        private string _queryArg;

        /// <summary>
        /// Gets and sets the property ProfileId. 
        /// <para>
        /// ID of profile to use for field-level encryption query argument-profile mapping
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ProfileId
        {
            get { return this._profileId; }
            set { this._profileId = value; }
        }

        // Check to see if ProfileId property is set
        internal bool IsSetProfileId()
        {
            return this._profileId != null;
        }

        /// <summary>
        /// Gets and sets the property QueryArg. 
        /// <para>
        /// Query argument for field-level encryption query argument-profile mapping.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string QueryArg
        {
            get { return this._queryArg; }
            set { this._queryArg = value; }
        }

        // Check to see if QueryArg property is set
        internal bool IsSetQueryArg()
        {
            return this._queryArg != null;
        }

    }
}