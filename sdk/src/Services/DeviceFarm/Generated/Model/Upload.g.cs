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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// An app or a set of one or more tests to upload or that have been uploaded.
    /// </summary>
    public partial class Upload
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The upload's ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 32, Max = 1011)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The upload's category. Allowed values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CURATED: An upload managed by AWS Device Farm.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PRIVATE: An upload managed by the AWS Device Farm customer.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public UploadCategory Category { get; set; }

        /// <summary>
        /// Checks to see if the Category property is set.
        /// </summary>
        internal bool IsSetCategory() => this.Category != null;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The upload's content type (for example, <c>application/octet-stream</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;

        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        /// When the upload was created.
        /// </para>
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// Checks to see if the Created property is set.
        /// </summary>
        internal bool IsSetCreated() => this.Created.HasValue;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A message about the upload's result.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 16384)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The upload's metadata. For example, for Android, this contains information that is
        /// parsed from the manifest and is displayed in the AWS Device Farm console after the
        /// associated app is uploaded.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string Metadata { get; set; }

        /// <summary>
        /// Checks to see if the Metadata property is set.
        /// </summary>
        internal bool IsSetMetadata() => this.Metadata != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The upload's file name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

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
        /// FAILED
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INITIALIZED
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PROCESSING
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SUCCEEDED
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public UploadStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

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
        /// APPIUM_RUBY_TEST_SPEC
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
        public UploadType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The presigned Amazon S3 URL that was used to store a file using a PUT request.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4096)]
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;
    }
}
