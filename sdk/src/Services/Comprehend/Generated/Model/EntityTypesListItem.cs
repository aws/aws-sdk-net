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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
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
namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// An entity type within a labeled training dataset that Amazon Comprehend uses to train
    /// a custom entity recognizer.
    /// </summary>
    public partial class EntityTypesListItem
    {
        private string _type;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// An entity type within a labeled training dataset that Amazon Comprehend uses to train
        /// a custom entity recognizer.
        /// </para>
        ///  
        /// <para>
        /// Entity types must not contain the following invalid characters: \n (line break), \\n
        /// (escaped line break, \r (carriage return), \\r (escaped carriage return), \t (tab),
        /// \\t (escaped tab), and , (comma).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}