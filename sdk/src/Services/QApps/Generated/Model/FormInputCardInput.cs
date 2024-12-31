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
    /// Represents a form input card for an Amazon Q App.
    /// </summary>
    public partial class FormInputCardInput
    {
        private InputCardComputeMode _computeMode;
        private string _id;
        private FormInputCardMetadata _metadata;
        private string _title;
        private CardType _type;

        /// <summary>
        /// Gets and sets the property ComputeMode. 
        /// <para>
        /// The compute mode of the form input card. This property determines whether individual
        /// participants of a data collection session can submit multiple response or one response.
        /// A compute mode of <c>append</c> shall allow participants to submit the same form multiple
        /// times with different values. A compute mode of <c>replace</c>code&gt; shall overwrite
        /// the current value for each participant.
        /// </para>
        /// </summary>
        public InputCardComputeMode ComputeMode
        {
            get { return this._computeMode; }
            set { this._computeMode = value; }
        }

        // Check to see if ComputeMode property is set
        internal bool IsSetComputeMode()
        {
            return this._computeMode != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the form input card.
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
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The metadata that defines the form input card data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FormInputCardMetadata Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title or label of the form input card.
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