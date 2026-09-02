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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
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
namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Maps a source CIDR range to the corresponding target CIDR range to use in the target
    /// network.
    /// </summary>
    public partial class CidrMapping
    {
        private string _originalCidr;
        private string _updatedCidr;

        /// <summary>
        /// Gets and sets the property OriginalCidr. 
        /// <para>
        /// The original CIDR range in the source network.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=9, Max=18)]
        public string OriginalCidr
        {
            get { return this._originalCidr; }
            set { this._originalCidr = value; }
        }

        // Check to see if OriginalCidr property is set
        internal bool IsSetOriginalCidr()
        {
            return this._originalCidr != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedCidr. 
        /// <para>
        /// The updated CIDR range to use in the target network.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=9, Max=18)]
        public string UpdatedCidr
        {
            get { return this._updatedCidr; }
            set { this._updatedCidr = value; }
        }

        // Check to see if UpdatedCidr property is set
        internal bool IsSetUpdatedCidr()
        {
            return this._updatedCidr != null;
        }

    }
}