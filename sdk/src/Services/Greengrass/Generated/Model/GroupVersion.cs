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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// Information on group version
    /// </summary>
    public partial class GroupVersion
    {
        private string _coreDefinitionVersionArn;
        private string _deviceDefinitionVersionArn;
        private string _functionDefinitionVersionArn;
        private string _loggerDefinitionVersionArn;
        private string _subscriptionDefinitionVersionArn;

        /// <summary>
        /// Gets and sets the property CoreDefinitionVersionArn. Core definition version arn for
        /// this group.
        /// </summary>
        public string CoreDefinitionVersionArn
        {
            get { return this._coreDefinitionVersionArn; }
            set { this._coreDefinitionVersionArn = value; }
        }

        // Check to see if CoreDefinitionVersionArn property is set
        internal bool IsSetCoreDefinitionVersionArn()
        {
            return this._coreDefinitionVersionArn != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceDefinitionVersionArn. Device definition version arn
        /// for this group.
        /// </summary>
        public string DeviceDefinitionVersionArn
        {
            get { return this._deviceDefinitionVersionArn; }
            set { this._deviceDefinitionVersionArn = value; }
        }

        // Check to see if DeviceDefinitionVersionArn property is set
        internal bool IsSetDeviceDefinitionVersionArn()
        {
            return this._deviceDefinitionVersionArn != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionDefinitionVersionArn. Function definition version
        /// arn for this group.
        /// </summary>
        public string FunctionDefinitionVersionArn
        {
            get { return this._functionDefinitionVersionArn; }
            set { this._functionDefinitionVersionArn = value; }
        }

        // Check to see if FunctionDefinitionVersionArn property is set
        internal bool IsSetFunctionDefinitionVersionArn()
        {
            return this._functionDefinitionVersionArn != null;
        }

        /// <summary>
        /// Gets and sets the property LoggerDefinitionVersionArn. Logger definitionv ersion arn
        /// for this group.
        /// </summary>
        public string LoggerDefinitionVersionArn
        {
            get { return this._loggerDefinitionVersionArn; }
            set { this._loggerDefinitionVersionArn = value; }
        }

        // Check to see if LoggerDefinitionVersionArn property is set
        internal bool IsSetLoggerDefinitionVersionArn()
        {
            return this._loggerDefinitionVersionArn != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriptionDefinitionVersionArn. Subscription definition
        /// version arn for this group.
        /// </summary>
        public string SubscriptionDefinitionVersionArn
        {
            get { return this._subscriptionDefinitionVersionArn; }
            set { this._subscriptionDefinitionVersionArn = value; }
        }

        // Check to see if SubscriptionDefinitionVersionArn property is set
        internal bool IsSetSubscriptionDefinitionVersionArn()
        {
            return this._subscriptionDefinitionVersionArn != null;
        }

    }
}