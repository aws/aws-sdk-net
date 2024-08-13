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
    /// Container for the parameters to the SearchAvailablePhoneNumbers operation.
    /// Searches for available phone numbers that you can claim to your Amazon Connect instance
    /// or traffic distribution group. If the provided <c>TargetArn</c> is a traffic distribution
    /// group, you can call this API in both Amazon Web Services Regions associated with the
    /// traffic distribution group.
    /// </summary>
    public partial class SearchAvailablePhoneNumbersRequest : AmazonConnectRequest
    {
        private string _instanceId;
        private int? _maxResults;
        private string _nextToken;
        private PhoneNumberCountryCode _phoneNumberCountryCode;
        private string _phoneNumberPrefix;
        private PhoneNumberType _phoneNumberType;
        private string _targetArn;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance that phone numbers are claimed to. You
        /// can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance. You must enter
        /// <c>InstanceId</c> or <c>TargetArn</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return per page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results. Use the value returned in the previous response
        /// in the next request to retrieve the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100000)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property PhoneNumberCountryCode. 
        /// <para>
        /// The ISO country code.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PhoneNumberCountryCode PhoneNumberCountryCode
        {
            get { return this._phoneNumberCountryCode; }
            set { this._phoneNumberCountryCode = value; }
        }

        // Check to see if PhoneNumberCountryCode property is set
        internal bool IsSetPhoneNumberCountryCode()
        {
            return this._phoneNumberCountryCode != null;
        }

        /// <summary>
        /// Gets and sets the property PhoneNumberPrefix. 
        /// <para>
        /// The prefix of the phone number. If provided, it must contain <c>+</c> as part of the
        /// country code.
        /// </para>
        /// </summary>
        public string PhoneNumberPrefix
        {
            get { return this._phoneNumberPrefix; }
            set { this._phoneNumberPrefix = value; }
        }

        // Check to see if PhoneNumberPrefix property is set
        internal bool IsSetPhoneNumberPrefix()
        {
            return this._phoneNumberPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property PhoneNumberType. 
        /// <para>
        /// The type of phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PhoneNumberType PhoneNumberType
        {
            get { return this._phoneNumberType; }
            set { this._phoneNumberType = value; }
        }

        // Check to see if PhoneNumberType property is set
        internal bool IsSetPhoneNumberType()
        {
            return this._phoneNumberType != null;
        }

        /// <summary>
        /// Gets and sets the property TargetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for Amazon Connect instances or traffic distribution
        /// groups that phone number inbound traffic is routed through. You must enter <c>InstanceId</c>
        /// or <c>TargetArn</c>. 
        /// </para>
        /// </summary>
        public string TargetArn
        {
            get { return this._targetArn; }
            set { this._targetArn = value; }
        }

        // Check to see if TargetArn property is set
        internal bool IsSetTargetArn()
        {
            return this._targetArn != null;
        }

    }
}