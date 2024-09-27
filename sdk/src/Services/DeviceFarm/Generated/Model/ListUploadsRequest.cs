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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
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
namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Container for the parameters to the ListUploads operation.
    /// Gets information about uploads, given an AWS Device Farm project ARN.
    /// </summary>
    public partial class ListUploadsRequest : AmazonDeviceFarmRequest
    {
        private string _arn;
        private string _nextToken;
        private UploadType _type;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the project for which you want to list uploads.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=32, Max=1011)]
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

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An identifier that was returned from the previous call to this operation, which can
        /// be used to return the next set of items in the list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=1024)]
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of upload.
        /// </para>
        ///  
        /// <para>
        /// Must be one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ANDROID_APP
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IOS_APP
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// WEB_APP
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EXTERNAL_DATA
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_JAVA_JUNIT_TEST_PACKAGE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_JAVA_TESTNG_TEST_PACKAGE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_PYTHON_TEST_PACKAGE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_NODE_TEST_PACKAGE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_RUBY_TEST_PACKAGE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_WEB_JAVA_JUNIT_TEST_PACKAGE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_WEB_JAVA_TESTNG_TEST_PACKAGE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_WEB_PYTHON_TEST_PACKAGE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_WEB_NODE_TEST_PACKAGE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_WEB_RUBY_TEST_PACKAGE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INSTRUMENTATION_TEST_PACKAGE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// XCTEST_TEST_PACKAGE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// XCTEST_UI_TEST_PACKAGE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_JAVA_JUNIT_TEST_SPEC
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_JAVA_TESTNG_TEST_SPEC
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_PYTHON_TEST_SPEC
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_NODE_TEST_SPEC
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  APPIUM_RUBY_TEST_SPEC
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_WEB_JAVA_JUNIT_TEST_SPEC
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_WEB_JAVA_TESTNG_TEST_SPEC
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_WEB_PYTHON_TEST_SPEC
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_WEB_NODE_TEST_SPEC
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_WEB_RUBY_TEST_SPEC
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INSTRUMENTATION_TEST_SPEC
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// XCTEST_UI_TEST_SPEC
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public UploadType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}