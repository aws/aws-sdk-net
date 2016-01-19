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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Container for the parameters to the CreateUpload operation.
    /// Uploads an app or test scripts.
    /// </summary>
    public partial class CreateUploadRequest : AmazonDeviceFarmRequest
    {
        private string _contentType;
        private string _name;
        private string _projectArn;
        private UploadType _type;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The upload's content type (for example, "application/octet-stream").
        /// </para>
        /// </summary>
        public string ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this._contentType != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The upload's file name.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ProjectArn. 
        /// <para>
        /// The ARN of the project for the upload.
        /// </para>
        /// </summary>
        public string ProjectArn
        {
            get { return this._projectArn; }
            set { this._projectArn = value; }
        }

        // Check to see if ProjectArn property is set
        internal bool IsSetProjectArn()
        {
            return this._projectArn != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The upload's upload type.
        /// </para>
        ///  
        /// <para>
        /// Must be one of the following values:
        /// </para>
        ///  <ul> <li>
        /// <para>
        /// ANDROID_APP: An Android upload.
        /// </para>
        /// </li> <li>
        /// <para>
        /// IOS_APP: An iOS upload.
        /// </para>
        /// </li> <li>
        /// <para>
        /// EXTERNAL_DATA: An external data upload.
        /// </para>
        /// </li> <li>
        /// <para>
        /// APPIUM_JAVA_JUNIT_TEST_PACKAGE: An Appium Java JUnit test package upload.
        /// </para>
        /// </li> <li>
        /// <para>
        /// APPIUM_JAVA_TESTNG_TEST_PACKAGE: An Appium Java TestNG test package upload.
        /// </para>
        /// </li> <li>
        /// <para>
        /// CALABASH_TEST_PACKAGE: A Calabash test package upload.
        /// </para>
        /// </li> <li>
        /// <para>
        /// INSTRUMENTATION_TEST_PACKAGE: An instrumentation upload.
        /// </para>
        /// </li> <li>
        /// <para>
        /// UIAUTOMATOR_TEST_PACKAGE: A uiautomator test package upload.
        /// </para>
        /// </li> <li>
        /// <para>
        /// XCTEST_TEST_PACKAGE: An XCode test package upload.
        /// </para>
        /// </li> <li>
        /// <para>
        /// APPIUM_WEB_JAVA_JUNIT_TEST_PACKAGE: An Appium Java JUnit test package upload.
        /// </para>
        /// </li> <li>
        /// <para>
        /// APPIUM_WEB_JAVA_TESTNG_TEST_PACKAGE: An Appium Java TestNG test package upload.
        /// </para>
        /// </li> </ul> 
        /// <para>
        /// <b>Note</b> If you call <code>CreateUpload</code> with <code>WEB_APP</code> specified,
        /// AWS Device Farm throws an <a>ArgumentException</a> error.
        /// </para>
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