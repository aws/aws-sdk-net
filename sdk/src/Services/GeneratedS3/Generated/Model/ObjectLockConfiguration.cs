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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// The container element for Object Lock configuration parameters.
    /// </summary>
    public partial class ObjectLockConfiguration
    {
        private ObjectLockEnabled _objectLockEnabled;
        private ObjectLockRule _rule;

        /// <summary>
        /// Gets and sets the property ObjectLockEnabled. 
        /// <para>
        /// Indicates whether this bucket has an Object Lock configuration enabled. Enable <c>ObjectLockEnabled</c>
        /// when you apply <c>ObjectLockConfiguration</c> to a bucket. 
        /// </para>
        /// </summary>
        public ObjectLockEnabled ObjectLockEnabled
        {
            get { return this._objectLockEnabled; }
            set { this._objectLockEnabled = value; }
        }

        // Check to see if ObjectLockEnabled property is set
        internal bool IsSetObjectLockEnabled()
        {
            return this._objectLockEnabled != null;
        }

        /// <summary>
        /// Gets and sets the property Rule. 
        /// <para>
        /// Specifies the Object Lock rule for the specified object. Enable the this rule when
        /// you apply <c>ObjectLockConfiguration</c> to a bucket. Bucket settings require both
        /// a mode and a period. The period can be either <c>Days</c> or <c>Years</c> but you
        /// must select one. You cannot specify <c>Days</c> and <c>Years</c> at the same time.
        /// </para>
        /// </summary>
        public ObjectLockRule Rule
        {
            get { return this._rule; }
            set { this._rule = value; }
        }

        // Check to see if Rule property is set
        internal bool IsSetRule()
        {
            return this._rule != null;
        }

    }
}