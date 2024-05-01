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
    /// This is the response object from the RegisterAccount operation.
    /// </summary>
    public partial class RegisterAccountResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTime;
        private IamResources _iamResources;
        private DateTime? _lastModificationTime;
        private RegistrationStatus _registerAccountStatus;
        private TimestreamResources _timestreamResources;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        ///  The time the account was registered, in seconds since epoch (January 1, 1970 at midnight
        /// UTC time). 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IamResources. 
        /// <para>
        ///  The registered IAM resource that allows Amazon Web Services IoT FleetWise to send
        /// data to Amazon Timestream. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IamResources IamResources
        {
            get { return this._iamResources; }
            set { this._iamResources = value; }
        }

        // Check to see if IamResources property is set
        internal bool IsSetIamResources()
        {
            return this._iamResources != null;
        }

        /// <summary>
        /// Gets and sets the property LastModificationTime. 
        /// <para>
        ///  The time this registration was last updated, in seconds since epoch (January 1, 1970
        /// at midnight UTC time). 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastModificationTime
        {
            get { return this._lastModificationTime; }
            set { this._lastModificationTime = value; }
        }

        // Check to see if LastModificationTime property is set
        internal bool IsSetLastModificationTime()
        {
            return this._lastModificationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RegisterAccountStatus. 
        /// <para>
        ///  The status of registering your Amazon Web Services account, IAM role, and Timestream
        /// resources. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RegistrationStatus RegisterAccountStatus
        {
            get { return this._registerAccountStatus; }
            set { this._registerAccountStatus = value; }
        }

        // Check to see if RegisterAccountStatus property is set
        internal bool IsSetRegisterAccountStatus()
        {
            return this._registerAccountStatus != null;
        }

        /// <summary>
        /// Gets and sets the property TimestreamResources.
        /// </summary>
        public TimestreamResources TimestreamResources
        {
            get { return this._timestreamResources; }
            set { this._timestreamResources = value; }
        }

        // Check to see if TimestreamResources property is set
        internal bool IsSetTimestreamResources()
        {
            return this._timestreamResources != null;
        }

    }
}