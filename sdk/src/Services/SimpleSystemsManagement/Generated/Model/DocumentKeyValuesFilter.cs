/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// One or more filters. Use a filter to return a more specific list of documents.
    /// 
    ///  
    /// <para>
    /// For keys, you can specify one or more tags that have been applied to a document. 
    /// </para>
    ///  
    /// <para>
    /// Other valid values include Owner, Name, PlatformTypes, and DocumentType.
    /// </para>
    ///  
    /// <para>
    /// Note that only one Owner can be specified in a request. For example: <code>Key=Owner,Values=Self</code>.
    /// </para>
    ///  
    /// <para>
    /// If you use Name as a key, you can use a name prefix to return a list of documents.
    /// For example, in the AWS CLI, to return a list of all documents that begin with <code>Te</code>,
    /// run the following command:
    /// </para>
    ///  
    /// <para>
    ///  <code>aws ssm list-documents --filters Key=Name,Values=Te</code> 
    /// </para>
    ///  
    /// <para>
    /// If you specify more than two keys, only documents that are identified by all the tags
    /// are returned in the results. If you specify more than two values for a key, documents
    /// that are identified by any of the values are returned in the results.
    /// </para>
    ///  
    /// <para>
    /// To specify a custom key and value pair, use the format <code>Key=tag:[tagName],Values=[valueName]</code>.
    /// </para>
    ///  
    /// <para>
    /// For example, if you created a Key called region and are using the AWS CLI to call
    /// the <code>list-documents</code> command: 
    /// </para>
    ///  
    /// <para>
    ///  <code>aws ssm list-documents --filters Key=tag:region,Values=east,west Key=Owner,Values=Self</code>
    /// 
    /// </para>
    /// </summary>
    public partial class DocumentKeyValuesFilter
    {
        private string _key;
        private List<string> _values = new List<string>();

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The name of the filter key.
        /// </para>
        /// </summary>
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The value for the filter key.
        /// </para>
        /// </summary>
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && this._values.Count > 0; 
        }

    }
}