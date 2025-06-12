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
 * Do not modify this file. This file is generated from the iotfleethub-2020-11-03.normal.json service model.
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
namespace Amazon.IoTFleetHub.Model
{
    /// <summary>
    /// This is the response object from the DescribeApplication operation.
    /// </summary>
    public partial class DescribeApplicationResponse : AmazonWebServiceResponse
    {
        private string _applicationArn;
        private long? _applicationCreationDate;
        private string _applicationDescription;
        private string _applicationId;
        private long? _applicationLastUpdateDate;
        private string _applicationName;
        private ApplicationState _applicationState;
        private string _applicationUrl;
        private string _errorMessage;
        private string _roleArn;
        private string _ssoClientId;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ApplicationArn. 
        /// <para>
        /// The ARN of the web application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
        public string ApplicationArn
        {
            get { return this._applicationArn; }
            set { this._applicationArn = value; }
        }

        // Check to see if ApplicationArn property is set
        internal bool IsSetApplicationArn()
        {
            return this._applicationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationCreationDate. 
        /// <para>
        /// The date (in Unix epoch time) when the application was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? ApplicationCreationDate
        {
            get { return this._applicationCreationDate; }
            set { this._applicationCreationDate = value; }
        }

        // Check to see if ApplicationCreationDate property is set
        internal bool IsSetApplicationCreationDate()
        {
            return this._applicationCreationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ApplicationDescription. 
        /// <para>
        /// An optional description of the web application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ApplicationDescription
        {
            get { return this._applicationDescription; }
            set { this._applicationDescription = value; }
        }

        // Check to see if ApplicationDescription property is set
        internal bool IsSetApplicationDescription()
        {
            return this._applicationDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique Id of the web application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationLastUpdateDate. 
        /// <para>
        /// The date (in Unix epoch time) when the application was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? ApplicationLastUpdateDate
        {
            get { return this._applicationLastUpdateDate; }
            set { this._applicationLastUpdateDate = value; }
        }

        // Check to see if ApplicationLastUpdateDate property is set
        internal bool IsSetApplicationLastUpdateDate()
        {
            return this._applicationLastUpdateDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the web application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string ApplicationName
        {
            get { return this._applicationName; }
            set { this._applicationName = value; }
        }

        // Check to see if ApplicationName property is set
        internal bool IsSetApplicationName()
        {
            return this._applicationName != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationState. 
        /// <para>
        /// The current state of the web application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ApplicationState ApplicationState
        {
            get { return this._applicationState; }
            set { this._applicationState = value; }
        }

        // Check to see if ApplicationState property is set
        internal bool IsSetApplicationState()
        {
            return this._applicationState != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationUrl. 
        /// <para>
        /// The URL of the web application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ApplicationUrl
        {
            get { return this._applicationUrl; }
            set { this._applicationUrl = value; }
        }

        // Check to see if ApplicationUrl property is set
        internal bool IsSetApplicationUrl()
        {
            return this._applicationUrl != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// A message that explains any failures included in the <c>applicationState</c> response
        /// field. This message explains failures in the <c>CreateApplication</c> and <c>DeleteApplication</c>
        /// actions.
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
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the role that the web application assumes when it interacts with Amazon
        /// Web Services IoT Core.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SsoClientId. 
        /// <para>
        /// The Id of the single sign-on client that you use to authenticate and authorize users
        /// on the web application.
        /// </para>
        /// </summary>
        public string SsoClientId
        {
            get { return this._ssoClientId; }
            set { this._ssoClientId = value; }
        }

        // Check to see if SsoClientId property is set
        internal bool IsSetSsoClientId()
        {
            return this._ssoClientId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A set of key/value pairs that you can use to manage the web application resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}