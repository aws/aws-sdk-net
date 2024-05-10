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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
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
namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides information about the account-level permissions settings that apply to an
    /// S3 bucket.
    /// </summary>
    public partial class AccountLevelPermissions
    {
        private BlockPublicAccess _blockPublicAccess;

        /// <summary>
        /// Gets and sets the property BlockPublicAccess. 
        /// <para>
        /// The block public access settings for the Amazon Web Services account that owns the
        /// bucket.
        /// </para>
        /// </summary>
        public BlockPublicAccess BlockPublicAccess
        {
            get { return this._blockPublicAccess; }
            set { this._blockPublicAccess = value; }
        }

        // Check to see if BlockPublicAccess property is set
        internal bool IsSetBlockPublicAccess()
        {
            return this._blockPublicAccess != null;
        }

    }
}