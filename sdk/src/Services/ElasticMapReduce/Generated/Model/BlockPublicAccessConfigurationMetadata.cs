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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Properties that describe the Amazon Web Services principal that created the <c>BlockPublicAccessConfiguration</c>
    /// using the <c>PutBlockPublicAccessConfiguration</c> action as well as the date and
    /// time that the configuration was created. Each time a configuration for block public
    /// access is updated, Amazon EMR updates this metadata.
    /// </summary>
    public partial class BlockPublicAccessConfigurationMetadata
    {
        private string _createdByArn;
        private DateTime? _creationDateTime;

        /// <summary>
        /// Gets and sets the property CreatedByArn. 
        /// <para>
        /// The Amazon Resource Name that created or last modified the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string CreatedByArn
        {
            get { return this._createdByArn; }
            set { this._createdByArn = value; }
        }

        // Check to see if CreatedByArn property is set
        internal bool IsSetCreatedByArn()
        {
            return this._createdByArn != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The date and time that the configuration was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationDateTime
        {
            get { return this._creationDateTime; }
            set { this._creationDateTime = value; }
        }

        // Check to see if CreationDateTime property is set
        internal bool IsSetCreationDateTime()
        {
            return this._creationDateTime.HasValue; 
        }

    }
}