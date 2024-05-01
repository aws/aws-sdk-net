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
 * Do not modify this file. This file is generated from the clouddirectory-2017-01-11.normal.json service model.
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
namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSchema operation.
    /// Creates a new schema in a development state. A schema can exist in three phases:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <i>Development:</i> This is a mutable phase of the schema. All new schemas are in
    /// the development phase. Once the schema is finalized, it can be published.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>Published:</i> Published schemas are immutable and have a version associated with
    /// them.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>Applied:</i> Applied schemas are mutable in a way that allows you to add new schema
    /// facets. You can also add new, nonrequired attributes to existing schema facets. You
    /// can apply only published schemas to directories. 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateSchemaRequest : AmazonCloudDirectoryRequest
    {
        private string _name;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name that is associated with the schema. This is unique to each account and in
        /// each region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
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