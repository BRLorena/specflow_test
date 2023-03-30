Feature: Exercises UI testing
    As a [ROLE]
    I want to [DO SOMETHING]

Background: User is at WebPage
    Given the user is at 'https://demoqa.com/'
    And chooses the area 'Elements' to start his exercise

    @NewUser
    Scenario: User wants to create a new account
        And clicks Text Box at Elements menu
        When the user submits the new user information
            | Full Name | Email  | Current Adress | Permanent Adress |
            | Bruno     | a@a.pt | VWFS-PAC-Porto | VWFS$#1          |
        Then the user sees a box with the created user
            | Name  | Email  | Current Adress | Permanent Adress |
            | Bruno | a@a.pt | VWFS-PAC-Porto | VWFS$#1          |


    @webtable
    Scenario: User wants to interact with the Text Box
        And clicks Web Tables at Elements menu
        When added the following user
            | First Name | Last Name | Email  | Age | Salary | Department |
            | Bruno      | Lorena    | a@a.pt | 27  | 90     | Tests      |
        Then sees the user at the table
            | First Name | Last Name | Email  | Age | Salary | Department |
            | Bruno      | Lorena    | a@a.pt | 27  | 90     | Tests      |


    @TableInteractions
    Scenario: User wants to interact with the Table
        And clicks Web Tables at Elements menu
        When the user orders columns by 'First Name'
        Then the values of 'First Name' are ordered


    @practiceform
    Scenario: User wants to create a Student Registration Form
        Given the user is at 'https://demoqa.com/'
        And chooses the area 'Forms' to start his exercise
        And clicks Practice Form at Forms menu
        When added the following user table
            | First Name | Last Name | Email     | Gender | Mobile     | Date of Birth | Subjects       | Hobbies         | Current Adress | State         | City |
            | Bruno      | Lorena    | mm@abc.pt | Male   | 9123456789 | 10-09-1995    | Chemistry Arts | Sports, Reading | Rua Professor  | Uttar Pradesh | Agra |
        Then the values that are presented of the user are
            | Student Name | Student Email | Gender | Mobile     | Date of Birth      | Subjects        | Hobbies         | Picture | Current Adress | State and City     |
            | Bruno Lorena | mm@abc.pt     | Male   | 9123456789 | 10 September, 1995 | Chemistry, Arts | Sports, Reading |         | Rua Professor  | Uttar Pradesh Agra |


    @links
    Scenario Outline: User wants to in
        And clicks 'Links' at Elements menu
        When the user clicks on the link '<http_status>'
        Then he sees the message Link has responded with status '<http_code>' and status text '<Text>'

        Examples:
            | http_code | http_status  | Text              |
            | 201       | created      | Created           |
            | 204       | no-content   | No Content        |
            | 301       | moved        | Moved Permanently |
            | 400       | bad-request  | Bad Request       |
            | 401       | unauthorized | Unauthorized      |
            | 403       | forbidden    | Forbidden         |
            | 404       | invalid-url  | Not Found         |

