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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// Describes the data model of a connector field. For example, for an <i>account</i>
    /// entity, the fields would be <i>account name</i>, <i>account ID</i>, and so on.
    /// </summary>
    public partial class ConnectorEntityField
    {
        private string _description;
        private DestinationFieldProperties _destinationProperties;
        private string _identifier;
        private string _label;
        private SourceFieldProperties _sourceProperties;
        private SupportedFieldTypeDetails _supportedFieldTypeDetails;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A description of the connector entity field. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationProperties. 
        /// <para>
        ///  The properties applied to a field when the connector is being used as a destination.
        /// 
        /// </para>
        /// </summary>
        public DestinationFieldProperties DestinationProperties
        {
            get { return this._destinationProperties; }
            set { this._destinationProperties = value; }
        }

        // Check to see if DestinationProperties property is set
        internal bool IsSetDestinationProperties()
        {
            return this._destinationProperties != null;
        }

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        ///  The unique identifier of the connector field. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        ///  The label applied to a connector entity field. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string Label
        {
            get { return this._label; }
            set { this._label = value; }
        }

        // Check to see if Label property is set
        internal bool IsSetLabel()
        {
            return this._label != null;
        }

        /// <summary>
        /// Gets and sets the property SourceProperties. 
        /// <para>
        ///  The properties that can be applied to a field when the connector is being used as
        /// a source. 
        /// </para>
        /// </summary>
        public SourceFieldProperties SourceProperties
        {
            get { return this._sourceProperties; }
            set { this._sourceProperties = value; }
        }

        // Check to see if SourceProperties property is set
        internal bool IsSetSourceProperties()
        {
            return this._sourceProperties != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedFieldTypeDetails. 
        /// <para>
        ///  Contains details regarding the supported <code>FieldType</code>, including the corresponding
        /// <code>filterOperators</code> and <code>supportedValues</code>. 
        /// </para>
        /// </summary>
        public SupportedFieldTypeDetails SupportedFieldTypeDetails
        {
            get { return this._supportedFieldTypeDetails; }
            set { this._supportedFieldTypeDetails = value; }
        }

        // Check to see if SupportedFieldTypeDetails property is set
        internal bool IsSetSupportedFieldTypeDetails()
        {
            return this._supportedFieldTypeDetails != null;
        }

    }
}