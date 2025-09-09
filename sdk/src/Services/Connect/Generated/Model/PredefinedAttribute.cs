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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Information about a predefined attribute.
    /// </summary>
    public partial class PredefinedAttribute
    {
        private PredefinedAttributeConfiguration _attributeConfiguration;
        private string _lastModifiedRegion;
        private DateTime? _lastModifiedTime;
        private string _name;
        private List<string> _purposes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private PredefinedAttributeValues _values;

        /// <summary>
        /// Gets and sets the property AttributeConfiguration. 
        /// <para>
        /// Custom metadata that is associated to predefined attributes to control behavior in
        /// upstream services, such as controlling how a predefined attribute should be displayed
        /// in the Amazon Connect admin website.
        /// </para>
        /// </summary>
        public PredefinedAttributeConfiguration AttributeConfiguration
        {
            get { return this._attributeConfiguration; }
            set { this._attributeConfiguration = value; }
        }

        // Check to see if AttributeConfiguration property is set
        internal bool IsSetAttributeConfiguration()
        {
            return this._attributeConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedRegion. 
        /// <para>
        /// Last modified region.
        /// </para>
        /// </summary>
        public string LastModifiedRegion
        {
            get { return this._lastModifiedRegion; }
            set { this._lastModifiedRegion = value; }
        }

        // Check to see if LastModifiedRegion property is set
        internal bool IsSetLastModifiedRegion()
        {
            return this._lastModifiedRegion != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// Last modified time.
        /// </para>
        /// </summary>
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the predefined attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property Purposes. 
        /// <para>
        /// Values that enable you to categorize your predefined attributes. You can use them
        /// in custom UI elements across the Amazon Connect admin website.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> Purposes
        {
            get { return this._purposes; }
            set { this._purposes = value; }
        }

        // Check to see if Purposes property is set
        internal bool IsSetPurposes()
        {
            return this._purposes != null && (this._purposes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The values of the predefined attribute.
        /// </para>
        /// </summary>
        public PredefinedAttributeValues Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null;
        }

    }
}