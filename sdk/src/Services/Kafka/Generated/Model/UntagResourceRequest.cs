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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
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
namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Container for the parameters to the UntagResource operation.
    /// Removes the tags associated with the keys that are provided in the query.
    /// </summary>
    public partial class UntagResourceRequest : AmazonKafkaRequest
    {
        private string _resourceArn;
        private List<string> _tagKeys = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ResourceArn.             
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies the resource that's associated
        /// with the tags.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property TagKeys.             
        /// <para>
        /// Tag keys must be unique for a given cluster. In addition, the following restrictions
        /// apply:
        /// </para>
        ///             <ul>               <li>                  
        /// <para>
        /// Each tag key must be unique. If you add a tag with a key that's already in       
        ///           use, your new tag overwrites the existing key-value pair. 
        /// </para>
        ///                </li>               <li>                  
        /// <para>
        /// You can't start a tag key with aws: because this prefix is reserved for use      
        ///            by  AWS.  AWS creates tags that begin with this prefix on your behalf,
        /// but                  you can't edit or delete them.
        /// </para>
        ///                </li>               <li>                  
        /// <para>
        /// Tag keys must be between 1 and 128 Unicode characters in length.
        /// </para>
        ///                </li>               <li>                  
        /// <para>
        /// Tag keys must consist of the following characters: Unicode letters, digits,      
        ///            white space, and the following special characters: _ . / = + -        
        ///             @.
        /// </para>
        ///                </li>            </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> TagKeys
        {
            get { return this._tagKeys; }
            set { this._tagKeys = value; }
        }

        // Check to see if TagKeys property is set
        internal bool IsSetTagKeys()
        {
            return this._tagKeys != null && (this._tagKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}