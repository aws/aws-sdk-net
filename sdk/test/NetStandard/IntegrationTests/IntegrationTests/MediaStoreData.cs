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
using System;
using System.Text;
using System.Threading.Tasks;
using Amazon.MediaStoreData;
using Amazon.MediaStoreData.Model;
using Xunit;
using System.IO;
using Amazon.MediaStore;
using Amazon.MediaStore.Model;
using System.Net;
using System.Threading;
using ContainerNotFoundException = Amazon.MediaStore.Model.ContainerNotFoundException;

namespace Amazon.DNXCore.IntegrationTests
{
    /// <summary>
    /// Tests for AWS MediaStoreData service
    /// </summary>
    public class MediaStoreData : TestBase<AmazonMediaStoreClient>
    {
        /// <summary>
        /// Name of the container that we want to create in AWS MediaStore Data
        /// </summary>
        private const string ContainerName = "TestContainerNetStandard";
        /// <summary>
        /// Object Path of the object that we want to create in AWS MediaStore Data
        /// </summary>
        private const string ObjectPath = "TestNetStandard";
        /// <summary>
        /// Timeout for when a test to fail (in seconds)
        /// </summary>
        private const int TestTimeout = 300;

        /// <summary>
        /// Creates a container in AWS MediaStore Data
        /// </summary>
        public async Task Init()
        {
            // AWS Media Store requires a container in order to call PutObject
            await CreateContainerAsync(ContainerName);
        }

        /// <summary>
        /// Deletes created container
        /// </summary>
        public async Task Cleanup()
        {
            // Delete the created container
            await DeleteContainerAsync(ContainerName);
        }

        /// <summary>
        /// Compresses a payload of type stream of a request using compression while calling <see cref="AmazonMediaStoreDataClient.PutObjectAsync"/>.
        /// </summary>
        [Fact (Skip="This test is currently turned off because at the time it was written, the models for this service" +
            " did not have compression traits required to compress the payload of the request. We added those traits manually" +
            " in the model and ran those tests to make sure that request compression feature works for streams.")]
        [Trait(CategoryAttribute, "MediaStoreData")]
        public async Task PutObjectTestAsync()
        {
            await UtilityMethods.WaitUntilAsync(async () =>
            {
                try
                {
                    await Init();

                    // Get endpoint Url of the created container
                    var endpoint = GetEndpointUrl(ContainerName).Result;

                    var config = new AmazonMediaStoreDataConfig
                    {
                        ServiceURL = endpoint,
                        DisableRequestCompression = false // Make sure that this flag is false in order to compress the stream
                    };

                    using (var client = new AmazonMediaStoreDataClient(config))
                    {
                        var putObjectRequest = new PutObjectRequest
                        {
                            Path = ObjectPath,
                            Body = new MemoryStream(Encoding.UTF8.GetBytes("Testing 123")), // We are passing a stream to the payload
                            ContentType = "application/octet-stream"
                        };

                        // Upload the file to AWS MediaStore Data
                        var response = await client.PutObjectAsync(putObjectRequest);

                        Assert.Equal(HttpStatusCode.OK, response.HttpStatusCode);

                        await WaitForObjectToBeListedAsync(client);
                    }
                }
                finally
                {
                    // If the test fails, we still want to clean up created resources
                    await Cleanup();
                }
            }, TimeSpan.FromSeconds(TestTimeout));
        }

        /// <summary>
        /// Creates a container with name <paramref name="containerName"/> if it doesn't already exist.
        /// </summary>
        /// <param name="containerName"> Name of the container that we want to delete </param>
        private async Task CreateContainerAsync(string containerName)
        {
            var client = new AmazonMediaStoreClient();
            // Wait until an existing container has been deleted
            var containerStatus = await WaitUntilDescribeContainerConditionMetAsync(client, containerName, (status) => status != ContainerStatus.DELETING, "Container is ready to use!");
            // Create a container only if it doesn't already exist
            if (containerStatus == null || containerStatus != ContainerStatus.ACTIVE)
            {
                var containerRequest = new CreateContainerRequest()
                {
                    ContainerName = containerName,
                };

                await client.CreateContainerAsync(containerRequest);
                // Wait until container's status is set to active
                await WaitUntilDescribeContainerConditionMetAsync(client, containerName, (status) => status == ContainerStatus.ACTIVE, "Container is ready to use!");
            }
        }

        /// <summary>
        /// Delete container given <paramref name="containerName"/>
        /// </summary>
        /// <param name="containerName"> Name of the container that we want to delete </param>
        private async Task DeleteContainerAsync(string containerName)
        {
            var endpoint = GetEndpointUrl(containerName).Result;

            using (var client = new AmazonMediaStoreDataClient(endpoint))
            {
                // Delete the objects (files) in the container
                var listObjectsResponse = await client.ListItemsAsync(new ListItemsRequest());

                foreach (var item in listObjectsResponse.Items)
                {
                    await client.DeleteObjectAsync(new DeleteObjectRequest
                    {
                        Path = item.Name,
                    });

                }

                var areObjectsDeleted = false;
                // Wait for all objects to be deleted
                do
                {
                    var listItemsResponse = await client.ListItemsAsync(new ListItemsRequest());
                    var remainingObjects = listItemsResponse.Items;

                    // Check if there are any objects left in the container
                    if (remainingObjects.Count == 0)
                    {
                        areObjectsDeleted = true;
                        Console.WriteLine("All objects in the container are deleted.");
                    }
                    else
                    {
                        // Sleep for a few seconds before checking again
                        Thread.Sleep(5000);
                    }
                } while (!areObjectsDeleted);
            }

            using (var client = new AmazonMediaStoreClient())
            {
                var containerRequest = new DeleteContainerRequest()
                {
                    ContainerName = containerName,
                };

                await client.DeleteContainerAsync(containerRequest);
            }
        }

        /// <summary>
        /// Get endpoint Url based off <paramref name="containerName"/>
        /// </summary>
        /// <param name="containerName"> Endpoint Url of the container holding this name </param>
        /// <returns> Endpoint url of the container </returns>
        private async Task<string> GetEndpointUrl(string containerName)
        {
            using (var client = new AmazonMediaStoreClient())
            {
                var containerRequest = new DescribeContainerRequest()
                {
                    ContainerName = containerName,
                };

                DescribeContainerResponse describeContainerResponse;
                describeContainerResponse = await client.DescribeContainerAsync(containerRequest);

                return describeContainerResponse.Container.Endpoint;
            }
        }


        // Define a delegate for the condition
        private delegate bool ConditionCheck(ContainerStatus containerStatus);

        /// <summary>
        /// Call <see cref="AmazonMediaStoreClient.DescribeContainerAsync"/> and wait until condition <paramref name="conditionCheck"/> is met or an exception has been thrown
        /// </summary>
        /// <param name="client"> <see cref="AmazonMediaStoreClient"/> client </param>
        /// <param name="containerName"> Container name </param>
        /// <param name="conditionCheck"> When this condition is met, we stop calling <see cref="AmazonMediaStoreClient.DescribeContainerAsync"/> </param>
        /// <param name="successMessage"> Console message for when the condiiton is met </param>
        /// <returns> Status of the container or null if an exception was thrown </returns>
        private async Task<ContainerStatus> WaitUntilDescribeContainerConditionMetAsync(AmazonMediaStoreClient client, string containerName, ConditionCheck conditionCheck, string successMessage)
        {
            bool isConditionMet = false;

            do
            {
                try
                {
                    var describeContainerResponse = await client.DescribeContainerAsync(new DescribeContainerRequest()
                    {
                        ContainerName = containerName
                    });

                    var containerStatus = describeContainerResponse.Container.Status;

                    // Check if the specified condition is met
                    if (conditionCheck(containerStatus))
                    {
                        isConditionMet = true;
                        Console.WriteLine(successMessage);
                        return containerStatus;
                    }
                    else
                    {
                        // Sleep for a few seconds before checking the status again
                        Thread.Sleep(5000);
                    }
                }
                // We don't have an existing container
                catch (ContainerNotFoundException e)
                {
                    Console.WriteLine(e);
                    return null;
                }
            } while (!isConditionMet);

            return null;
        }

        /// <summary>
        /// Wait until objects are listed in the container
        /// </summary>
        /// <param name="client"> <see cref="AmazonMediaStoreDataClient"/> client </param>
        private async Task WaitForObjectToBeListedAsync(AmazonMediaStoreDataClient client)
        {
            var isObjectProcessing = true;

            do
            {
                // Call DescribeObject to get the object's processing status
                var describeObjectRequest = new ListItemsRequest
                {
                    Path = ""
                };

                try
                {
                    var describeObjectResponse = await client.ListItemsAsync(describeObjectRequest);


                    // Check if the processing status is "Completed"
                    if (describeObjectResponse?.Items != null)
                    {
                        foreach (var item in describeObjectResponse.Items)
                        {
                            if (item.Name.Equals(ObjectPath))
                            {
                                isObjectProcessing = false;
                                Console.WriteLine("Object processing is complete.");
                            }
                        }
                    }
                    else
                    {
                        // Object is still processing, wait for the specified interval before retrying
                        Thread.Sleep(5000);
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            } while (isObjectProcessing);
        }
    }
}
