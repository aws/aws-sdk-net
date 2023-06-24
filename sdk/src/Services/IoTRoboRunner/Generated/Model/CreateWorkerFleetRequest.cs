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
 * Do not modify this file. This file is generated from the iot-roborunner-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTRoboRunner.Model
{
    /// <summary>
    /// Container for the parameters to the CreateWorkerFleet operation.
    /// Grants permission to create a worker fleet
    /// </summary>
    public partial class CreateWorkerFleetRequest : AmazonIoTRoboRunnerRequest
    {
        private string _additionalFixedProperties;
        private string _clientToken;
        private string _name;
        private string _site;

        /// <summary>
        /// Gets and sets the property AdditionalFixedProperties.
        /// </summary>
        [AWSProperty(Min=1, Max=131072)]
        public string AdditionalFixedProperties
        {
            get { return this._additionalFixedProperties; }
            set { this._additionalFixedProperties = value; }
        }

        // Check to see if AdditionalFixedProperties property is set
        internal bool IsSetAdditionalFixedProperties()
        {
            return this._additionalFixedProperties != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken.
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Name.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// Gets and sets the property Site.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1011)]
        public string Site
        {
            get { return this._site; }
            set { this._site = value; }
        }

        // Check to see if Site property is set
        internal bool IsSetSite()
        {
            return this._site != null;
        }

    }
}