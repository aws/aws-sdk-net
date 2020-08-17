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
 * Do not modify this file. This file is generated from the sms-2016-10-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServerMigrationService.Model
{
    /// <summary>
    /// Configuration for validating an instance.
    /// </summary>
    public partial class ServerValidationConfiguration
    {
        private string _name;
        private Server _server;
        private ServerValidationStrategy _serverValidationStrategy;
        private UserDataValidationParameters _userDataValidationParameters;
        private string _validationId;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property Server.
        /// </summary>
        public Server Server
        {
            get { return this._server; }
            set { this._server = value; }
        }

        // Check to see if Server property is set
        internal bool IsSetServer()
        {
            return this._server != null;
        }

        /// <summary>
        /// Gets and sets the property ServerValidationStrategy. 
        /// <para>
        /// The validation strategy.
        /// </para>
        /// </summary>
        public ServerValidationStrategy ServerValidationStrategy
        {
            get { return this._serverValidationStrategy; }
            set { this._serverValidationStrategy = value; }
        }

        // Check to see if ServerValidationStrategy property is set
        internal bool IsSetServerValidationStrategy()
        {
            return this._serverValidationStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property UserDataValidationParameters. 
        /// <para>
        /// The validation parameters.
        /// </para>
        /// </summary>
        public UserDataValidationParameters UserDataValidationParameters
        {
            get { return this._userDataValidationParameters; }
            set { this._userDataValidationParameters = value; }
        }

        // Check to see if UserDataValidationParameters property is set
        internal bool IsSetUserDataValidationParameters()
        {
            return this._userDataValidationParameters != null;
        }

        /// <summary>
        /// Gets and sets the property ValidationId. 
        /// <para>
        /// The ID of the validation.
        /// </para>
        /// </summary>
        public string ValidationId
        {
            get { return this._validationId; }
            set { this._validationId = value; }
        }

        // Check to see if ValidationId property is set
        internal bool IsSetValidationId()
        {
            return this._validationId != null;
        }

    }
}