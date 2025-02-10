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
 * Do not modify this file. This file is generated from the qapps-2023-11-27.normal.json service model.
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
namespace Amazon.QApps.Model
{
    /// <summary>
    /// The input shape for defining a query card in an Amazon Q App.
    /// </summary>
    public partial class QQueryCardInput
    {
        private AttributeFilter _attributeFilter;
        private string _id;
        private CardOutputSource _outputSource;
        private string _prompt;
        private string _title;
        private CardType _type;

        /// <summary>
        /// Gets and sets the property AttributeFilter. 
        /// <para>
        /// Turns on filtering of responses based on document attributes or metadata fields.
        /// </para>
        /// </summary>
        public AttributeFilter AttributeFilter
        {
            get { return this._attributeFilter; }
            set { this._attributeFilter = value; }
        }

        // Check to see if AttributeFilter property is set
        internal bool IsSetAttributeFilter()
        {
            return this._attributeFilter != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the query card.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property OutputSource. 
        /// <para>
        /// The source or type of output to generate for the query card.
        /// </para>
        /// </summary>
        public CardOutputSource OutputSource
        {
            get { return this._outputSource; }
            set { this._outputSource = value; }
        }

        // Check to see if OutputSource property is set
        internal bool IsSetOutputSource()
        {
            return this._outputSource != null;
        }

        /// <summary>
        /// Gets and sets the property Prompt. 
        /// <para>
        /// The prompt or instructions displayed for the query card.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50000)]
        public string Prompt
        {
            get { return this._prompt; }
            set { this._prompt = value; }
        }

        // Check to see if Prompt property is set
        internal bool IsSetPrompt()
        {
            return this._prompt != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title or label of the query card.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the card.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CardType Type
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