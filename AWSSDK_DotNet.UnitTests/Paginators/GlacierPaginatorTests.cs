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
 * Do not modify this file. This file is generated from the glacier-2012-06-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

using Amazon.Runtime.Internal;
using Amazon.Glacier;
using Amazon.Glacier.Model;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Paginators
{
    [TestClass]
    public class GlacierPaginatorTests
    {

        #region ListJobsEnumerator
      
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Paginators")]
        [TestCategory("Glacier")]
        public void TestListJobsEnumerator()
        {
            var mock = new Mock<IAmazonGlacier>();

            mock.Setup(client => client.ListJobs(It.Is<ListJobsRequest>(r => r.Marker == null)))
                .Returns(new ListJobsResponse
                {
                    Marker = "A",
                    JobList = new List<GlacierJobDescription> 
                    {
                        new GlacierJobDescription { ArchiveId = "item1.0" },
                        new GlacierJobDescription { ArchiveId = "item1.1" }
                    }
                });

            mock.Setup(client => client.ListJobs(It.Is<ListJobsRequest>(r => r.Marker == "A")))
                .Returns(new ListJobsResponse
                {
                    Marker = "AA",
                    JobList = new List<GlacierJobDescription> 
                    {
                        new GlacierJobDescription { ArchiveId = "item2.0" },
                        new GlacierJobDescription { ArchiveId = "item2.1" }
                    }
                });

            mock.Setup(client => client.ListJobs(It.Is<ListJobsRequest>(r => r.Marker == "AA")))
                .Returns(new ListJobsResponse
                {
                    JobList = new List<GlacierJobDescription> 
                    {
                        new GlacierJobDescription { ArchiveId = "item3.0" },
                    }
                });

            var items = Paginator.Paginate<GlacierJobDescription, ListJobsRequest, ListJobsResponse>(new ListJobsRequest(), mock.Object.ListJobs);

            var itemEnumerator = items.GetEnumerator();

            for (var i = 1; i <= 3; i++)
            {
                for (var j = 0; j < 2; j++)
                {
                    if (!itemEnumerator.MoveNext())
                        break;
                    mock.Verify(client => client.ListJobs(It.IsAny<ListJobsRequest>()), Times.Exactly(i));
                        Assert.AreEqual(String.Format("item{0}.{1}", i, j), itemEnumerator.Current.ArchiveId);
                }
            }

            mock.Verify(client => client.ListJobs(It.IsAny<ListJobsRequest>()), Times.Exactly(3));

        }

        #endregion

        #region ListMultipartUploadsEnumerator
      
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Paginators")]
        [TestCategory("Glacier")]
        public void TestListMultipartUploadsEnumerator()
        {
            var mock = new Mock<IAmazonGlacier>();

            mock.Setup(client => client.ListMultipartUploads(It.Is<ListMultipartUploadsRequest>(r => r.UploadIdMarker == null)))
                .Returns(new ListMultipartUploadsResponse
                {
                    Marker = "A",
                    UploadsList = new List<UploadListElement> 
                    {
                        new UploadListElement { ArchiveDescription = "item1.0" },
                        new UploadListElement { ArchiveDescription = "item1.1" }
                    }
                });

            mock.Setup(client => client.ListMultipartUploads(It.Is<ListMultipartUploadsRequest>(r => r.UploadIdMarker == "A")))
                .Returns(new ListMultipartUploadsResponse
                {
                    Marker = "AA",
                    UploadsList = new List<UploadListElement> 
                    {
                        new UploadListElement { ArchiveDescription = "item2.0" },
                        new UploadListElement { ArchiveDescription = "item2.1" }
                    }
                });

            mock.Setup(client => client.ListMultipartUploads(It.Is<ListMultipartUploadsRequest>(r => r.UploadIdMarker == "AA")))
                .Returns(new ListMultipartUploadsResponse
                {
                    UploadsList = new List<UploadListElement> 
                    {
                        new UploadListElement { ArchiveDescription = "item3.0" },
                    }
                });

            var items = Paginator.Paginate<UploadListElement, ListMultipartUploadsRequest, ListMultipartUploadsResponse>(new ListMultipartUploadsRequest(), mock.Object.ListMultipartUploads);

            var itemEnumerator = items.GetEnumerator();

            for (var i = 1; i <= 3; i++)
            {
                for (var j = 0; j < 2; j++)
                {
                    if (!itemEnumerator.MoveNext())
                        break;
                    mock.Verify(client => client.ListMultipartUploads(It.IsAny<ListMultipartUploadsRequest>()), Times.Exactly(i));
                        Assert.AreEqual(String.Format("item{0}.{1}", i, j), itemEnumerator.Current.ArchiveDescription);
                }
            }

            mock.Verify(client => client.ListMultipartUploads(It.IsAny<ListMultipartUploadsRequest>()), Times.Exactly(3));

        }

        #endregion

        #region ListPartsEnumerator
      
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Paginators")]
        [TestCategory("Glacier")]
        public void TestListPartsEnumerator()
        {
            var mock = new Mock<IAmazonGlacier>();

            mock.Setup(client => client.ListParts(It.Is<ListPartsRequest>(r => r.Marker == null)))
                .Returns(new ListPartsResponse
                {
                    Marker = "A",
                    Parts = new List<PartListElement> 
                    {
                        new PartListElement { RangeInBytes = "item1.0" },
                        new PartListElement { RangeInBytes = "item1.1" }
                    }
                });

            mock.Setup(client => client.ListParts(It.Is<ListPartsRequest>(r => r.Marker == "A")))
                .Returns(new ListPartsResponse
                {
                    Marker = "AA",
                    Parts = new List<PartListElement> 
                    {
                        new PartListElement { RangeInBytes = "item2.0" },
                        new PartListElement { RangeInBytes = "item2.1" }
                    }
                });

            mock.Setup(client => client.ListParts(It.Is<ListPartsRequest>(r => r.Marker == "AA")))
                .Returns(new ListPartsResponse
                {
                    Parts = new List<PartListElement> 
                    {
                        new PartListElement { RangeInBytes = "item3.0" },
                    }
                });

            var items = Paginator.Paginate<PartListElement, ListPartsRequest, ListPartsResponse>(new ListPartsRequest(), mock.Object.ListParts);

            var itemEnumerator = items.GetEnumerator();

            for (var i = 1; i <= 3; i++)
            {
                for (var j = 0; j < 2; j++)
                {
                    if (!itemEnumerator.MoveNext())
                        break;
                    mock.Verify(client => client.ListParts(It.IsAny<ListPartsRequest>()), Times.Exactly(i));
                        Assert.AreEqual(String.Format("item{0}.{1}", i, j), itemEnumerator.Current.RangeInBytes);
                }
            }

            mock.Verify(client => client.ListParts(It.IsAny<ListPartsRequest>()), Times.Exactly(3));

        }

        #endregion

        #region ListVaultsEnumerator
      
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Paginators")]
        [TestCategory("Glacier")]
        public void TestListVaultsEnumerator()
        {
            var mock = new Mock<IAmazonGlacier>();

            mock.Setup(client => client.ListVaults(It.Is<ListVaultsRequest>(r => r.Marker == null)))
                .Returns(new ListVaultsResponse
                {
                    Marker = "A",
                    VaultList = new List<DescribeVaultOutput> 
                    {
                        new DescribeVaultOutput { VaultARN = "item1.0" },
                        new DescribeVaultOutput { VaultARN = "item1.1" }
                    }
                });

            mock.Setup(client => client.ListVaults(It.Is<ListVaultsRequest>(r => r.Marker == "A")))
                .Returns(new ListVaultsResponse
                {
                    Marker = "AA",
                    VaultList = new List<DescribeVaultOutput> 
                    {
                        new DescribeVaultOutput { VaultARN = "item2.0" },
                        new DescribeVaultOutput { VaultARN = "item2.1" }
                    }
                });

            mock.Setup(client => client.ListVaults(It.Is<ListVaultsRequest>(r => r.Marker == "AA")))
                .Returns(new ListVaultsResponse
                {
                    VaultList = new List<DescribeVaultOutput> 
                    {
                        new DescribeVaultOutput { VaultARN = "item3.0" },
                    }
                });

            var items = Paginator.Paginate<DescribeVaultOutput, ListVaultsRequest, ListVaultsResponse>(new ListVaultsRequest(), mock.Object.ListVaults);

            var itemEnumerator = items.GetEnumerator();

            for (var i = 1; i <= 3; i++)
            {
                for (var j = 0; j < 2; j++)
                {
                    if (!itemEnumerator.MoveNext())
                        break;
                    mock.Verify(client => client.ListVaults(It.IsAny<ListVaultsRequest>()), Times.Exactly(i));
                        Assert.AreEqual(String.Format("item{0}.{1}", i, j), itemEnumerator.Current.VaultARN);
                }
            }

            mock.Verify(client => client.ListVaults(It.IsAny<ListVaultsRequest>()), Times.Exactly(3));

        }

        #endregion

 
      
    }
}