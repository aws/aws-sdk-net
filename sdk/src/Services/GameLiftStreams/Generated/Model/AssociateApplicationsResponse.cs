<<<<<<< HEAD
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
 * Do not modify this file. This file is generated from the gameliftstreams-2018-05-10.normal.json service model.
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
namespace Amazon.GameLiftStreams.Model
{
    /// <summary>
    /// This is the response object from the AssociateApplications operation.
    /// </summary>
    public partial class AssociateApplicationsResponse : AmazonWebServiceResponse
    {
        private List<string> _applicationArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _arn;

        /// <summary>
        /// Gets and sets the property ApplicationArns. 
        /// <para>
        /// A set of applications that are associated to the stream group.
        /// </para>
        ///  
        /// <para>
        /// This value is a set of either <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference-arns.html">Amazon
        /// Resource Names (ARN)</a> or IDs that uniquely identify application resources. Format
        /// example: ARN-<c>arn:aws:gameliftstreams:us-west-2:123456789012:application/9ZY8X7Wv6</c>
        /// or ID-<c>9ZY8X7Wv6</c>. 
        /// </para>
        /// </summary>
        public List<string> ApplicationArns
        {
            get { return this._applicationArns; }
            set { this._applicationArns = value; }
        }

        // Check to see if ApplicationArns property is set
        internal bool IsSetApplicationArns()
        {
            return this._applicationArns != null && (this._applicationArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// A stream group that is associated to the applications.
        /// </para>
        ///  
        /// <para>
        /// This value is a <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference-arns.html">Amazon
        /// Resource Name (ARN)</a> or ID that uniquely identifies the stream group resource.
        /// Format example: ARN-<c>arn:aws:gameliftstreams:us-west-2:123456789012:streamgroup/1AB2C3De4</c>
        /// or ID-<c>1AB2C3De4</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

    }
}
|||||||
=======
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
 * Do not modify this file. This file is generated from the gameliftstreams-2018-05-10.normal.json service model.
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
namespace Amazon.GameLiftStreams.Model
{
    /// <summary>
    /// This is the response object from the AssociateApplications operation.
    /// </summary>
    public partial class AssociateApplicationsResponse : AmazonWebServiceResponse
    {
        private List<string> _applicationArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _arn;

        /// <summary>
        /// Gets and sets the property ApplicationArns. 
        /// <para>
        /// A set of applications that are associated to the stream group.
        /// </para>
        ///  
        /// <para>
        /// This value is a set of either <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference-arns.html">Amazon
        /// Resource Names (ARN)</a> or IDs that uniquely identify application resources. Format
        /// example: ARN-<c>arn:aws:gameliftstreams:us-west-2:123456789012:application/a-9ZY8X7Wv6</c>
        /// or ID-<c>a-9ZY8X7Wv6</c>. 
        /// </para>
        /// </summary>
        public List<string> ApplicationArns
        {
            get { return this._applicationArns; }
            set { this._applicationArns = value; }
        }

        // Check to see if ApplicationArns property is set
        internal bool IsSetApplicationArns()
        {
            return this._applicationArns != null && (this._applicationArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// A stream group that is associated to the applications.
        /// </para>
        ///  
        /// <para>
        /// This value is a <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference-arns.html">Amazon
        /// Resource Name (ARN)</a> or ID that uniquely identifies the stream group resource.
        /// Format example: ARN-<c>arn:aws:gameliftstreams:us-west-2:123456789012:streamgroup/sg-1AB2C3De4</c>
        /// or ID-<c>sg-1AB2C3De4</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

    }
}
>>>>>>> b6da6ace600c307cc9bd6dbf99b06a9d2b81da7e
