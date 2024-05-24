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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
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
namespace Amazon.IoTAnalytics.Model
{
    /// <summary>
    /// An activity that performs a transformation on a message.
    /// </summary>
    public partial class PipelineActivity
    {
        private AddAttributesActivity _addAttributes;
        private ChannelActivity _channel;
        private DatastoreActivity _datastore;
        private DeviceRegistryEnrichActivity _deviceRegistryEnrich;
        private DeviceShadowEnrichActivity _deviceShadowEnrich;
        private FilterActivity _filter;
        private LambdaActivity _lambda;
        private MathActivity _math;
        private RemoveAttributesActivity _removeAttributes;
        private SelectAttributesActivity _selectAttributes;

        /// <summary>
        /// Gets and sets the property AddAttributes. 
        /// <para>
        /// Adds other attributes based on existing attributes in the message.
        /// </para>
        /// </summary>
        public AddAttributesActivity AddAttributes
        {
            get { return this._addAttributes; }
            set { this._addAttributes = value; }
        }

        // Check to see if AddAttributes property is set
        internal bool IsSetAddAttributes()
        {
            return this._addAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property Channel. 
        /// <para>
        /// Determines the source of the messages to be processed.
        /// </para>
        /// </summary>
        public ChannelActivity Channel
        {
            get { return this._channel; }
            set { this._channel = value; }
        }

        // Check to see if Channel property is set
        internal bool IsSetChannel()
        {
            return this._channel != null;
        }

        /// <summary>
        /// Gets and sets the property Datastore. 
        /// <para>
        /// Specifies where to store the processed message data.
        /// </para>
        /// </summary>
        public DatastoreActivity Datastore
        {
            get { return this._datastore; }
            set { this._datastore = value; }
        }

        // Check to see if Datastore property is set
        internal bool IsSetDatastore()
        {
            return this._datastore != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceRegistryEnrich. 
        /// <para>
        /// Adds data from the IoT device registry to your message.
        /// </para>
        /// </summary>
        public DeviceRegistryEnrichActivity DeviceRegistryEnrich
        {
            get { return this._deviceRegistryEnrich; }
            set { this._deviceRegistryEnrich = value; }
        }

        // Check to see if DeviceRegistryEnrich property is set
        internal bool IsSetDeviceRegistryEnrich()
        {
            return this._deviceRegistryEnrich != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceShadowEnrich. 
        /// <para>
        /// Adds information from the IoT Device Shadow service to a message.
        /// </para>
        /// </summary>
        public DeviceShadowEnrichActivity DeviceShadowEnrich
        {
            get { return this._deviceShadowEnrich; }
            set { this._deviceShadowEnrich = value; }
        }

        // Check to see if DeviceShadowEnrich property is set
        internal bool IsSetDeviceShadowEnrich()
        {
            return this._deviceShadowEnrich != null;
        }

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// Filters a message based on its attributes.
        /// </para>
        /// </summary>
        public FilterActivity Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null;
        }

        /// <summary>
        /// Gets and sets the property Lambda. 
        /// <para>
        /// Runs a Lambda function to modify the message.
        /// </para>
        /// </summary>
        public LambdaActivity Lambda
        {
            get { return this._lambda; }
            set { this._lambda = value; }
        }

        // Check to see if Lambda property is set
        internal bool IsSetLambda()
        {
            return this._lambda != null;
        }

        /// <summary>
        /// Gets and sets the property Math. 
        /// <para>
        /// Computes an arithmetic expression using the message's attributes and adds it to the
        /// message.
        /// </para>
        /// </summary>
        public MathActivity Math
        {
            get { return this._math; }
            set { this._math = value; }
        }

        // Check to see if Math property is set
        internal bool IsSetMath()
        {
            return this._math != null;
        }

        /// <summary>
        /// Gets and sets the property RemoveAttributes. 
        /// <para>
        /// Removes attributes from a message.
        /// </para>
        /// </summary>
        public RemoveAttributesActivity RemoveAttributes
        {
            get { return this._removeAttributes; }
            set { this._removeAttributes = value; }
        }

        // Check to see if RemoveAttributes property is set
        internal bool IsSetRemoveAttributes()
        {
            return this._removeAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property SelectAttributes. 
        /// <para>
        /// Used to create a new message using only the specified attributes from the original
        /// message. 
        /// </para>
        /// </summary>
        public SelectAttributesActivity SelectAttributes
        {
            get { return this._selectAttributes; }
            set { this._selectAttributes = value; }
        }

        // Check to see if SelectAttributes property is set
        internal bool IsSetSelectAttributes()
        {
            return this._selectAttributes != null;
        }

    }
}