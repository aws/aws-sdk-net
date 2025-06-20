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
    /// This is the response object from the GetBucketLocation operation.
    /// </summary>
    public partial class GetBucketLocationResponse : AmazonWebServiceResponse
    {
        private S3Region _location;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// Specifies the Region where the bucket resides. For a list of all the Amazon S3 supported
        /// location constraints by Region, see <a href="https://docs.aws.amazon.com/general/latest/gr/rande.html#s3_region">Regions
        /// and Endpoints</a>.
        /// </para>
        ///  
        /// <para>
        /// Buckets in Region <c>us-east-1</c> have a LocationConstraint of <c>null</c>. Buckets
        /// with a LocationConstraint of <c>EU</c> reside in <c>eu-west-1</c>.
        /// </para>
        /// </summary>
        public S3Region Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

    }
}