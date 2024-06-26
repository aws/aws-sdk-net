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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Configuration information for document attributes. Document attributes are metadata
    /// or fields associated with your documents. For example, the company department name
    /// associated with each document.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/amazonq/latest/business-use-dg/doc-attributes.html">Understanding
    /// document attributes</a>.
    /// </para>
    /// </summary>
    public partial class DocumentAttributeConfiguration
    {
        private string _name;
        private Status _search;
        private AttributeType _type;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the document attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=30)]
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

        /// <summary>
        /// Gets and sets the property Search. 
        /// <para>
        /// Information about whether the document attribute can be used by an end user to search
        /// for information on their web experience.
        /// </para>
        /// </summary>
        public Status Search
        {
            get { return this._search; }
            set { this._search = value; }
        }

        // Check to see if Search property is set
        internal bool IsSetSearch()
        {
            return this._search != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of document attribute.
        /// </para>
        /// </summary>
        public AttributeType Type
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