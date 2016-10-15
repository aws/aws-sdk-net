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
    /// An app or a set of one or more tests to upload or that have been uploaded.
    /// </summary>
    public partial class Upload
    {
        private string _arn;
        private string _contentType;
        private DateTime? _created;
        private string _message;
        private string _metadata;
        private string _name;
        private UploadStatus _status;
        private UploadType _type;
        private string _url;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The upload's ARN.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Created. 
        /// <para>
        /// When the upload was created.
        /// </para>
        /// </summary>
        public DateTime Created
        {
            get { return this._created.GetValueOrDefault(); }
            set { this._created = value; }
        }

        // Check to see if Created property is set
        internal bool IsSetCreated()
        {
            return this._created.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A message about the upload's result.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The upload's metadata. For example, for Android, this contains information that is
        /// parsed from the manifest and is displayed in the AWS Device Farm console after the
        /// associated app is uploaded.
        /// </para>
        /// </summary>
        public string Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null;
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The upload's status.
        /// </para>
        ///  
        /// <para>
        /// Must be one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// FAILED: A failed status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INITIALIZED: An initialized status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PROCESSING: A processing status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SUCCEEDED: A succeeded status.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public UploadStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The upload's type.
        /// </para>
        ///  
        /// <para>
        /// Must be one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ANDROID_APP: An Android upload.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IOS_APP: An iOS upload.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// WEB_APP: A web appliction upload.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EXTERNAL_DATA: An external data upload.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_JAVA_JUNIT_TEST_PACKAGE: An Appium Java JUnit test package upload.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_JAVA_TESTNG_TEST_PACKAGE: An Appium Java TestNG test package upload.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_PYTHON_TEST_PACKAGE: An Appium Python test package upload.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_WEB_JAVA_JUNIT_TEST_PACKAGE: An Appium Java JUnit test package upload.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_WEB_JAVA_TESTNG_TEST_PACKAGE: An Appium Java TestNG test package upload.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_WEB_PYTHON_TEST_PACKAGE: An Appium Python test package upload.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CALABASH_TEST_PACKAGE: A Calabash test package upload.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INSTRUMENTATION_TEST_PACKAGE: An instrumentation upload.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UIAUTOMATION_TEST_PACKAGE: A uiautomation test package upload.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UIAUTOMATOR_TEST_PACKAGE: A uiautomator test package upload.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// XCTEST_TEST_PACKAGE: An XCode test package upload.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// XCTEST_UI_TEST_PACKAGE: An XCode UI test package upload.
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

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The pre-signed Amazon S3 URL that was used to store a file through a corresponding
        /// PUT request.
        /// </para>
        /// </summary>
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

    }
}