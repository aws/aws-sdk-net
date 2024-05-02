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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
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
namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// Information about the registered Amazon Timestream resources or errors, if any.
    /// </summary>
    public partial class TimestreamRegistrationResponse
    {
        private string _errorMessage;
        private RegistrationStatus _registrationStatus;
        private string _timestreamDatabaseArn;
        private string _timestreamDatabaseName;
        private string _timestreamTableArn;
        private string _timestreamTableName;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// A message associated with a registration error.
        /// </para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property RegistrationStatus. 
        /// <para>
        /// The status of registering your Amazon Timestream resources. The status can be one
        /// of <c>REGISTRATION_SUCCESS</c>, <c>REGISTRATION_PENDING</c>, <c>REGISTRATION_FAILURE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RegistrationStatus RegistrationStatus
        {
            get { return this._registrationStatus; }
            set { this._registrationStatus = value; }
        }

        // Check to see if RegistrationStatus property is set
        internal bool IsSetRegistrationStatus()
        {
            return this._registrationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property TimestreamDatabaseArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Timestream database.
        /// </para>
        /// </summary>
        public string TimestreamDatabaseArn
        {
            get { return this._timestreamDatabaseArn; }
            set { this._timestreamDatabaseArn = value; }
        }

        // Check to see if TimestreamDatabaseArn property is set
        internal bool IsSetTimestreamDatabaseArn()
        {
            return this._timestreamDatabaseArn != null;
        }

        /// <summary>
        /// Gets and sets the property TimestreamDatabaseName. 
        /// <para>
        /// The name of the Timestream database.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=255)]
        public string TimestreamDatabaseName
        {
            get { return this._timestreamDatabaseName; }
            set { this._timestreamDatabaseName = value; }
        }

        // Check to see if TimestreamDatabaseName property is set
        internal bool IsSetTimestreamDatabaseName()
        {
            return this._timestreamDatabaseName != null;
        }

        /// <summary>
        /// Gets and sets the property TimestreamTableArn. 
        /// <para>
        /// The ARN of the Timestream database table.
        /// </para>
        /// </summary>
        public string TimestreamTableArn
        {
            get { return this._timestreamTableArn; }
            set { this._timestreamTableArn = value; }
        }

        // Check to see if TimestreamTableArn property is set
        internal bool IsSetTimestreamTableArn()
        {
            return this._timestreamTableArn != null;
        }

        /// <summary>
        /// Gets and sets the property TimestreamTableName. 
        /// <para>
        /// The name of the Timestream database table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=255)]
        public string TimestreamTableName
        {
            get { return this._timestreamTableName; }
            set { this._timestreamTableName = value; }
        }

        // Check to see if TimestreamTableName property is set
        internal bool IsSetTimestreamTableName()
        {
            return this._timestreamTableName != null;
        }

    }
}